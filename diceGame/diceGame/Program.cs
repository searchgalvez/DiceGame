using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int playerRandomNum;
            int enemyRandomNum;
            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("press any key to roll the dice");


                Console.ReadLine();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("you rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("enemy AI rolled a " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("player wins this round!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("draw!");
                }

                Console.WriteLine("the score is now - Player: " + playerPoints + ". Enemy: " + enemyPoints + ".");
                Console.WriteLine();
            
            }


            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("you win!!!");
            }
            else if (enemyPoints > playerPoints)
            {
                Console.WriteLine("you loose!!");
            }
            else
            {
                Console.WriteLine("its a Draw");
            }
            Console.ReadLine();
            

        }
    }
}
