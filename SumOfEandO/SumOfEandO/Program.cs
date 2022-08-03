namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            int numberofodds = 0;
            int numberofevens = 0;

            int sumofodds = 0;
            int sumofevens = 0;

            int value;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write((i + 0) + " Enter the index' value: ");
                value = int.Parse(Console.ReadLine());

                numbers[i] = value;
            }
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    numberofevens++;
                    sumofevens += numbers[j];
                }
                else
                {
                    numberofodds++;
                    sumofevens += numbers[j];
                }
            }
            if (sumofevens > sumofodds)
            {
                Console.WriteLine("The sum of even numbers is greater than the sum of odd numbers!");
            }
            else
            {
                Console.WriteLine("The sum of odd numbers is greater than the sum of even numbers!");
            }

            Console.WriteLine("*************************************************************");
            Console.WriteLine("The sum of even numbers: " + sumofevens);
            Console.WriteLine("The number of even numbers: " + numberofevens);
            Console.WriteLine("*************************************************************");
            Console.WriteLine("The sum of odd numbers: " + sumofodds);
            Console.WriteLine("The number of  odd numbers: " + numberofodds);


        }
    }
}