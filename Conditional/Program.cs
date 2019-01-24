/* 
 Author: Tharick Moulton
 Date: 1/21/2019
 Comments:This C# Console application code demonstrates the use of 
           conditional statements after getting input from users
*/


using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {   // Ask user to enter a grade 
            Console.WriteLine("What grade do you expect to receive in ISM 4300?");
            
            try

            {
                // This will gather users input
                string userInput = Console.ReadLine();

                int Usergrade = int.Parse(userInput); // Parse user input into new variable "Usergrade"



                /* 
                    The below IF/ELSE IF/ELSE statements is used to conditionally
                    test the users input. Various options are available
                    depending on the expected grade entered by the user. Then, insde of each IF/ELSE IF/ELSE
                    there is a switch conditional statement that displays a message depending
                    on the integer grade entered by the user. 
                 */


                if ((Usergrade > 97) && (Usergrade <= 100))
                {

                    Console.WriteLine("You will receive an A+");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
                else if ((Usergrade > 91) && (Usergrade < 98))

                { Console.WriteLine("You will receive an A");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);

                }
                else if ((Usergrade > 89 ) && (Usergrade < 92))
                {
                    Console.WriteLine("You will receive an A-");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

                else if ((Usergrade > 87) && (Usergrade < 90))
                {
                    Console.WriteLine("You will receive an B+");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

                else if ((Usergrade > 81) && (Usergrade < 88))
                {
                    Console.WriteLine("You will receive an B");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

                else if ((Usergrade > 79) && (Usergrade < 82))
                {
                    Console.WriteLine("You will receive an B-");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

                else if ((Usergrade > 77) && (Usergrade < 80))
                {
                    Console.WriteLine("You will receive an C+");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

                else if ((Usergrade > 71) && (Usergrade < 78))
                {
                    Console.WriteLine("You will receive an C");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

                else if ((Usergrade > 69) && (Usergrade < 72))
                {
                    Console.WriteLine("You will receive an C-");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

                else if ((Usergrade > 67) && (Usergrade < 70))
                {
                    Console.WriteLine("You will receive an D+");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

                else if ((Usergrade > 61) && (Usergrade < 68))
                {
                    Console.WriteLine("You will receive an D");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

                else if ((Usergrade > 59) && (Usergrade < 62))
                {
                    Console.WriteLine("You will receive an D-");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }

                else if (Usergrade < 60)
                {
                    Console.WriteLine("You will receive an F");
                    Console.WriteLine("Press any key to exit the program and try again...");
                    Console.ReadKey(true);
                }
            } //End of try
            catch
            {
                Console.WriteLine("Please use an integer data type for expected grade");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }//End of catch
            




            } // End of static 


        }// End of class 

    }// End of namespace

