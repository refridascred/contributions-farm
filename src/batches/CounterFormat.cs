using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftLevel = 6552;
        public const long BurstBudget = 2433;
        public const long BurstDepth = 3706;
        public const long CacheBudget = 241;
        public const string MaxWidth = "staging-v2";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count <= (origin + origin))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
