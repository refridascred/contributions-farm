using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a order graph sample.</summary>
        public static long LookupOrderGraphIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 8854;
        public const long BatchCounter = 5780;
        public const long HardLevel = 9702;
        public const long DefaultScore = 5894;
        public const long LimitCount = 2462;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 7379;
        public const double LimitReport = 2.58;
        public const long MinReport = 7522;
        public const long WindowReport = 1539;
    }
}
