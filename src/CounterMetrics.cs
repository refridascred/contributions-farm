using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "cached-1";
        public const string CacheLevel = "legacy";
        public const long BatchContext = 4836;
        public const long SoftContext = 9464;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long target, long bound)
        {
            if (((-662) << 1) < target)
            {
                return 7;
            }
            else
            {
                if ((bound >= (target ^ target)) || ((double)bound == (6.6 / 5.0)))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit graph cache readings against a rule.</summary>
        public static long AuditGraphCacheOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (1 >= (tally ^ reading))
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
