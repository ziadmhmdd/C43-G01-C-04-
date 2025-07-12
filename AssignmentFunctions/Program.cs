using System.Globalization;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace AssignmentFunctions
{
    internal class Program
    {
        #region 1-Passing By Value_Q1

        #region 1-Passing By Value
        //static void Swap(int X, int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        #endregion

        #region 2-Passing By Reference
        //static void SwapRef(ref int X, ref int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //}
        #endregion
        #endregion

        #region Question2 Explain the difference between passing (Reference type parameters)


        #region 1-Passing By Value
        //static void Func1(int[] arr)
        //{
        //    if(arr == null)
        //    {
        //        return;
        //    }
        //    arr[0] = 100;
        //    arr = new int[] { 4, 5, 6, 7 };

        //}

        #endregion

        #region 2-Passing By Reference
        //static void Func2(ref int[] arr)
        //{
        //    if (arr == null)
        //    {
        //        return;
        //    }
        //    arr[0] = 100;
        //    arr = new int[] { 4, 5, 6, 7 };
        //}
        #endregion

        #endregion


        #region Question3 Write a c# Function that accept 4 parameters

        //static void Sum_Sub(int n1, int n2 ,out int sum,out int sub)
        //{
        //    sum = n1 + n2;
        //    sub = n1 - n2;
        //}

        #endregion

        #region Question4 Write a program in C# Sharp to create a function
        //static int SumOfDigit(int n)
        //{
        //    int sum = 0;
        //    while (n!= 0)
        //    {
        //        sum += n % 10;
        //        n /= 10;

        //    }
        //    return sum;
        //}

        #endregion

        #region Question5 Create a function named "IsPrime", 
        //static bool IsPrime(int n )
        //{
        //    if(n < 2 )
        //        return false;
        //    for(int i= 2; i < n; i++)
        //    {
        //        if(n % i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}



        #endregion

        #region Question6 Create a function named MinMaxArray, to return the minimum and maximum 
        //static void MinMaxArray(int[] arr, ref int max, ref int min)
        //{
        //    if (arr is null)
        //        return;
        //    max = arr[0];
        //    min = arr[0];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if(max < arr[i])
        //            max = arr[i];
        //        else if(min > arr[i])
        //            min = arr[i];   
        //    }
        //}


        #endregion

        #region 7-Create function to calculate the factorial of the number specified as parameter

        //static long factorial(int num)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= num; i++)
        //    {
        //        result = i;
        //    }
        //    return result;
        //}

        #endregion

        #region Question8 Create a function named "ChangeChar" 

        //static string ChangeChar(string text, int index, char ch)
        //{
        //    text = text.Remove(index, 1);
        //    text = text.Insert(index,ch.ToString());
        //    return text;

        //}


        #endregion

        static void Main()
        {
            #region Question 1 Value type parameters_Q1

            #region 1-Passing By Value
            //int n1 = 10, n2 = 20;
            //Swap(n1, n2);
            //Console.WriteLine($"n1 = {n1}");
            //Console.WriteLine($"n2 = {n2}");

            #endregion

            #region 2-Passing By Reference
            //int x = 10, y = 5;
            //SwapRef(ref x,ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            #endregion

            #endregion

            #region Question2 Reference type parameters


            #region 1-Passing By Value
            //int[] numbers = { 0, 1, 2, 3, 4 };
            //Func1(numbers);
            //Console.WriteLine(numbers[0]);
            #endregion

            #region 2-Passing By Reference

            //Func2(ref numbers);
            //Console.WriteLine(numbers[0]);

            #endregion

            #endregion

            #region Question3
            //bool flag1, flag2;
            //int n1, n2, sum, sub;
            //try
            //{
            //    do
            //    {
            //        Console.WriteLine("Enter 1st number: ");
            //        flag1 = int.TryParse(Console.ReadLine(), out n1);
            //        Console.WriteLine("Enter 2nd number: ");
            //        flag2 = int.TryParse(Console.ReadLine(), out n2);

            //    } while (!(flag1 && flag2));
            //    Sum_Sub(n1,n2,out sum ,out sub);
            //    Console.WriteLine($"Sum = {sum}");
            //    Console.WriteLine($"Sub = {sub}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region Question4
            //int n = 239475; // 2394.7

            //Console.WriteLine(SumOfDigit(n));
            #endregion

            #region Question5
            //int n = 10;

            //Console.WriteLine(IsPrime(n));
            #endregion

            #region Question6
            //int[] numbers = { 0, -50, 10, 50, 344, 5 };
            //int max =0,min = 0;
            //MinMaxArray(numbers, ref max, ref min);
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            #endregion

            #region Question7

            //Console.Write("Enter a number to find its factorial: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine();

        



            //int fact = 0;
            //Console.WriteLine(factorial(fact));


            #endregion

            #region Question8
            //Console.WriteLine("Enter a string: ");
            //string word = Console.ReadLine();

            //char letter;
            //int index;
            //string result;

            //Console.WriteLine("Enter Index : ");
            //index = int.Parse(Console.ReadLine());  
            //Console.WriteLine("Enter letter : ");
            //letter = char.Parse(Console.ReadLine());

            //result = ChangeChar(word, index, letter);
            //Console.WriteLine($"New Word = {result}");

            #endregion



            #region 9-. Write a program that prints an identity matrix using for loop,
            //Console.Write("Enter the size of the identity matrix (n): ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("Identity Matrix of size {0}x{0}:"  );
            //for (int i = 0; i < n; i++)  
            //{
            //    for (int j = 0; j < n; j++)  
            //    {
            //        if (i == j)
            //            Console.Write("1 ");
            //        else
            //            Console.Write("0 ");
            //    }
            //    Console.WriteLine(); 
            //}
            #endregion



            #region 10-Write a program in C# Sharp to find the sum of all elements 

            //            Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];
            //int sum = 0;

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element[{0}]: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}

            //Console.WriteLine("The sum of all elements in the array is: " + sum); 
            #endregion


            #region 11- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //Console.Write("Enter the size of the arrays: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] array1 = new int[n];
            //int[] array2 = new int[n];
            //int[] mergedArray = new int[2 * n];

            //Console.WriteLine("Enter elements for the first array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element[{0}]: ", i);
            //    array1[i] = int.Parse(Console.ReadLine());
            //}

            #endregion

            #region 12-Write a program in C# Sharp to find maximum and minimum element in an array

            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element[{0}]: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //} 
            #endregion


            #region 13-Write a program in C# Sharp to find the second largest element in an array.
            //    Console.Write("Enter the number of elements in the array (at least 2): ");
            //int n = int.Parse(Console.ReadLine());

            //if (n < 2)
            //{
            //    Console.WriteLine("Array must contain at least two elements.");
            //    return;
            //}

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Element[{0}]: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //} 
            #endregion

            #region 16-Write a program to create two multidimensional arrays of same size.


            //Console.Write("Enter number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter number of columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] firstArray = new int[rows, cols];
            //int[,] secondArray = new int[rows, cols];

            //// Input values for the first array
            //Console.WriteLine("\nEnter elements for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Element[{i},{j}]: ");
            //        firstArray[i, j] = int.Parse(Console.ReadLine());
            //    }
            //} 
            #endregion

            #region 17- Write a Program to Print One Dimensional Array in Reverse Order

            //Console.Write("Enter the number of elements in the array: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Element[{i}]: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nArray elements in reverse order:");
            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Console.WriteLine(); 
            #endregion


        }

    }

    }
    

