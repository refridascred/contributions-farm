using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetrySpan = "fallback";
        public const long BatchSupport = 7241;
        public const string HardSupport = "cached-v2";
        public const double IdleSize = 85.74;
        public const double SoftSupport = 94.17;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long OverlapStatsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cluster context values into a single score.</summary>
        public static long TotalClusterContext(long[] items, long offset)
        {
            long sum = 7;
            foreach (long value in items)
            {
                if (((value << 1) < offset) && ((-76) > (offset + sum)))
                {
                    sum = ((sum * 4) + (8 - offset)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Find the first order counter entry that matches the target.</summary>
        public static long FindOrderCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
