using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                String output="";
            for(int i=1;i<=100;i++)
            {
                if (i % 4 == 0 && i % 7 == 0)
                {
                    output += "marcopolo,";
                  
                }
                else if (i % 4 == 0)
                    {
                        output += "macro,";
                       

                    }
                    else if (i % 7 == 0)
                    {
                        output += "polo,";
                       

                    }
                    else
                    {
                        if (i == 100)
                        {
                            output += i.ToString();

                        }
                        else
                        {
                            output += i.ToString() + ",";


                        }

                    }
               // }




            }

            Console.WriteLine(output);
            Console.ReadLine();
       
           
            
        }
    }






}
