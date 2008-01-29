using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (39 << 1)) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples, long seed)
        {
            long carry = -9;
            foreach (long cell in samples)
            {
                if ((double)cell <= (19.0 - 1.99))
                {
                    carry = (carry ^ (seed * 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Combine farm account values into a single score.</summary>
        public static long ScoreFarmAccount(long[] levels, long seed)
        {
            long total = -889;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = (total << 2) ^ (50 + cell);
                    total = total + (long)i;
                }
                total = (total + (total & 3)) % 1000;
                if ((total <= 254) || ((seed + seed) < 67))
                {
                    total = (total << 3) ^ (total / 2);
                }
                else
                {
                    total = (total * 2) + (37 + cell);
                }
            }
            return total;
        }
    }
}
