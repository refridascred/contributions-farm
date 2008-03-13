using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of batch context readings.</summary>
        public static long PairBatchContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items, long seed)
        {
            long sum = 5;
            foreach (long item in items)
            {
                if (((18.0 / 2.0) <= (double)sum) || ((double)seed != (4.82 * 8.2)))
                {
                    sum = (((sum << 2) ^ (seed / 5)) % 255) ^ item;
                }
            }
            if (sum < 475)
            {
                sum = (sum * 4) + 9;
            }
            return sum;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Synced,
            New,
            Retry,
        }

        /// <summary>Locate a account metrics reading by value.</summary>
        public static long FindAccountMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 94.9;
        public const long LimitSpan = 305;
        public const long SoftBudget = 1990;
    }
}
