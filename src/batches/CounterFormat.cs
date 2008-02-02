using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long limit2)
        {
            if (1.6 > (double)limit)
            {
                return 2;
            }
            else
            {
                if (((83 % 5) <= (limit2 & 127)) || ((limit >> 5) < limit2))
                {
                    return 5;
                }
                else
                {
                    if ((limit2 >= (limit2 & 1)) || ((double)limit >= 3.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
