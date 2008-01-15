using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] samples, long seed)
        {
            long carry = 828;
            foreach (long cell in samples)
            {
                carry = (((carry * 3) + (carry - seed)) % 97) - cell;
            }
            return carry;
        }
    }
}
