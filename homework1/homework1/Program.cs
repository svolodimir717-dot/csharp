namespace homework1
{
    class Program
    {
        static void Main()
        {

            
            // TASK 1
            






            /*
            Console.Write("Enter number (1-100): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                Console.WriteLine("Error!");
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
            */










            // TASK 2








            /*
            Console.Write("Enter first number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter percentage: ");
            double percent = Convert.ToDouble(Console.ReadLine());

            double result = number * percent / 100;

            Console.WriteLine("Result: " + result);
            */










            // TASK 3









            /*
            Console.Write("Enter first digit: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second digit: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third digit: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter fourth digit: ");
            int d = Convert.ToInt32(Console.ReadLine());

            if (a < 0 || a > 9 || b < 0 || b > 9 || c < 0 || c > 9 || d < 0 || d > 9)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                int number = a * 1000 + b * 100 + c * 10 + d;

                Console.WriteLine("Result: " + number);
            }
            */







            // TASK 4








            /*
            Console.Write("Enter six-digit number: ");
            string number = Console.ReadLine();

            if (number.Length != 6)
            {
                Console.WriteLine("Error! Enter six digits.");
            }
            else
            {
                Console.Write("Enter first position (1-6): ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second position (1-6): ");
                int b = Convert.ToInt32(Console.ReadLine());

                if (a < 1 || a > 6 || b < 1 || b > 6)
                {
                    Console.WriteLine("Error! Wrong position.");
                }
                else
                {
                    char[] digits = number.ToCharArray();

                    char temp = digits[a - 1];
                    digits[a - 1] = digits[b - 1];
                    digits[b - 1] = temp;

                    Console.WriteLine("Result: " + new string(digits));
                }
            }
            */










            // TASK 5









            /*
            Console.Write("Enter date (dd.MM.yyyy): ");
            string input = Console.ReadLine();

            DateTime date;

            if (DateTime.TryParseExact(input, "dd.MM.yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out date))
            {
                if (date.Month == 12 || date.Month == 1 || date.Month == 2)
                {
                    Console.Write("Winter ");
                }
                else if (date.Month >= 3 && date.Month <= 5)
                {
                    Console.Write("Spring ");
                }
                else if (date.Month >= 6 && date.Month <= 8)
                {
                    Console.Write("Summer ");
                }
                else
                {
                    Console.Write("Autumn ");
                }

                Console.WriteLine(date.DayOfWeek);
            }
            else
            {
                Console.WriteLine("Error! Wrong date.");
            }
            */










            // TASK 6










            /*
            Console.WriteLine("1 - Fahrenheit to Celsius");
            Console.WriteLine("2 - Celsius to Fahrenheit");

            Console.Write("Choose option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            if (choice == 1)
            {
                double result = (temperature - 32) * 5 / 9;

                Console.WriteLine("Celsius: " + result);
            }
            else if (choice == 2)
            {
                double result = temperature * 9 / 5 + 32;

                Console.WriteLine("Fahrenheit: " + result);
            }
            else
            {
                Console.WriteLine("Error! Wrong option.");
            }
            */












            // TASK 7










            /*
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("Even numbers:");

            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            */










            // TASK 8









            /*
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Not an Armstrong number.");
            }
            else
            {
                int temp = number;
                int count = 0;
                double sum = 0;

                do
                {
                    count++;
                    temp = temp / 10;
                }
                while (temp > 0);

                temp = number;

                do
                {
                    int digit = temp % 10;
                    double power = 1;

                    for (int i = 0; i < count; i++)
                    {
                        power = power * digit;
                    }

                    sum = sum + power;

                    temp = temp / 10;
                }
                while (temp > 0);

                if (sum == number)
                {
                    Console.WriteLine("Armstrong number!");
                }
                else
                {
                    Console.WriteLine("Not an Armstrong number.");
                }
            }
            */










            // TASK 9










            
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (number > 1 && sum == number)
            {
                Console.WriteLine("Perfect number!");
            }
            else
            {
                Console.WriteLine("Not a perfect number.");
            }
            

        }
    }
}
