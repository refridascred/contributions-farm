using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a filter account reading by value.</summary>
        public static long LocateFilterAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryLevel = 1172;
        public const double CacheSchema = 39.85;
        public const long HardSchema = 10;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCount = 1491;
        public const long BaseCounter = 8249;
        public const string MaxCounter = "local";
        public const long RetryFactor = 7328;
        public const long LimitCounter = 2522;
    }
}
