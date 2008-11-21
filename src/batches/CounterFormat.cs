using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples, long origin)
        {
            long result = 621;
            foreach (long cell in samples)
            {
                if (!((result % 16) > (cell & 15)))
                {
                    result = (result ^ (result - cell)) % 1000;
                }
                if ((3.7 * 8.04) != (double)origin)
                {
                    result = (result + (81 % 60)) % 1000;
                }
                else
                {
                    result = ((result << 3) ^ (74 + origin)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = sum - (sum - offset);
                sum = (sum ^ (sum * 5)) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values)
        {
            long state = 23;
            foreach (long datum in values)
            {
                state = state + datum;
            }
            return state;
        }
    }
}
