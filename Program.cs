using System;

namespace UserInputSofiaChumpitazi
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Hi, this is Sofia Chumpitazi");
            //Instructions for users to type and press Enter key
            Console.WriteLine("Type something here... When you are finished, press Enter! ");
            userInput = Console.ReadLine();
            Console.WriteLine("The user typed: ");
            Console.WriteLine(userInput);

            Console.ReadKey();
        }

       
        
    }
}
