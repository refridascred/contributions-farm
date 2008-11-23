using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a cache entry reading by value.</summary>
        public static long FindCacheEntryIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 27.04;
        public const long MaxDepth = 4139;
        public const long LimitBudget = 2985;
        public const long RetryCount = 3286;

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long limit, long target)
        {
            long span = limit + target;
            if (((target / 3) > span) || ((19.0 - 2.3) == (double)span))
            {
                return 1;
            }
            else
            {
                if (span > (5 >> 5))
                {
                    return 4;
                }
                else
                {
                    if (!(span <= (limit * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
