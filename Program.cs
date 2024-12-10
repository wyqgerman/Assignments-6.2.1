namespace Assignments_6._2._1
{
    class Stack

    {
        private int[] stackArray;  
    private int top;           
    private int maxSize;       

    public Stack(int size)
    {
        maxSize = size;
        stackArray = new int[maxSize];
        top = -1; 
    }

    public void Push(int element)
    {
        if (top >= maxSize - 1)
        {
            Console.WriteLine("Stack Overflow! Cannot push more elements.");
            return;
        }
        stackArray[++top] = element;
        Console.WriteLine($"Pushed {element} to the stack.");
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow! The stack is empty.");
            return -1; 
        }
        int poppedElement = stackArray[top--];
        Console.WriteLine($"Popped {poppedElement} from the stack.");
        return poppedElement;
    }

    public void Display()
    {
        if (top == -1)
        {
            Console.WriteLine("The stack is empty.");
            return;
        }

        Console.WriteLine("Stack elements (top to bottom):");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(stackArray[i]);
        }
    }
}
}
