///////Homework//////


//1) n - ededinin faktorialini hesablayin.


//int n = 6;
//int result = 1;

//for (int i = 1; i <= n; i++)
//{
//    result *= i;
//}
//Console.WriteLine(result);


//2) Verilmis arrayin icerisinde cut ededlerin ceminin kvadratini hesablayin.


//int[] nums = { 1, 2, 6, 3, 5 };
//int sum = 0;
//int result = 1;

//for (int i = 0; i < nums.Length; i++)
//{
//    if (nums[i] % 2 == 0)
//    {
//        sum += nums[i];
//    }
//}result = sum * sum;
//Console.WriteLine(result);


//3) n ededi gelir. n - ededinin 2-ni hansisa quvvete yukseltdikde alinan edede beraber olub-olmadigini tapin. 

//int n = 32;
//bool quvvetidir = false;

//if (n == 1)
//{
//    Console.WriteLine("Quvvetidir");
//}
//else if (n % 2 == 1)
//{
//    Console.WriteLine("Quvveti deyil");
//}
//else
//{
//    for (int i = 2; i <= n; i *= 2)
//    {
//        if (i % n == 0) 
//        {
//            quvvetidir = true;
//        }
//    }
//    if (quvvetidir==true)
//    {
//        Console.WriteLine("Quvvetidir");
//    }
//    else
//    {
//        Console.WriteLine("Quvveti deyil");
//    }
//}


///////////Classwork/////////////

//int[] arr = { 1, 2, 3, 4, 5 };
//for(int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 3)
//    {
//        Console.WriteLine("Tapildi - " + arr[i]);
//        break;
//    }
//}

////////////////////////////////

//int[] arr = { 1, 2, 2, 3, 4, 5 };
//int count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 2)
//    {
//        count++;
//        if (count == 2)
//        {
//            Console.WriteLine("Found 2 times - " + arr[i]);
//            break;
//        }
//    }
//}

//////////////////////////

//int a = 5;
//int b = a;
//b = 100;
//Console.WriteLine(a);
//Console.WriteLine(b);

////////////////////////////

//int[] arr1 = { 1, 2, 3, 4 };
//int[] arr2 = arr1;
//arr2[0] = 100;
//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);

//////////////////////////

//string name1 = "test";
//string name2 = name1;
//name2 = "salam";

//Console.WriteLine(name1);
//Console.WriteLine(name2);

/////////////////////////////


//int[] arr = { 1, 2, 3, 4, 5, 6 };
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 2)
//    {
//        continue;
//    }
//    if (arr[i] == 4)
//    {
//        break;
//    }
//    Console.WriteLine(arr[i]);
//}

///////////////////////

//int a = 6;
//int b = a++;
//Console.WriteLine(a);
//Console.WriteLine(b);

////////////////////////

//int a = 100;
//int b = ++a;

//Console.WriteLine(a);
//Console.WriteLine(b);

//////////////////////

//int a = 15;
//int b = --a;
//int c = b++;

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);