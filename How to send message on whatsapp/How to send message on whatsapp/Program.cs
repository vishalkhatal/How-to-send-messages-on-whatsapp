using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace How_to_send_message_on_whatsapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Token at twilio.com/console
            const string accountSid = "ACbc58356cf0839e2541f69e59a2c64931";
            const string authToken = "XXXXXXX";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Hello there!",
                from: new Twilio.Types.PhoneNumber("whatsapp:+XXXXX"),
                to: new Twilio.Types.PhoneNumber("whatsapp:+XXxx")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
