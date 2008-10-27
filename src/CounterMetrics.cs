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

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
