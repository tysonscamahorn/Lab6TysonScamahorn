void stacknoparams()
{
    int x = 64;
    int y = 73;
    int w = 96;
    int z = 4;
    int f = x*y;
}
void StackWithParams(int x,int y)
{
    int ab = 17;
    int c = x*y+ab;
}
void stackWithHeap(int a, int y, int x, string z)
{
    int b = a*y;
    int c = y*x;
    string hi = "hello";
    Console.WriteLine(hi);
}
void StackOver()
{
    int x = 64;
    string z = "hello";
    Console.WriteLine(z+x);
    StackOver();
}
stacknoparams();
StackWithParams(5,7);
stackWithHeap(5,7,8,"sup");
StackOver();