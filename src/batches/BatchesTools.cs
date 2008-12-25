using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = (total + (total - (long)i)) % 97;
                total = (total + total) % 4096;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a account order counter forward.</summary>
        public static long StepAccountOrder(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                if ((8.2 + 2.86) <= (double)(long)i)
                {
                    continue;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
