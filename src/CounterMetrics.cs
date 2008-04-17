using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double StepBudget = 46.49;
        public const long SoftWidth = 4204;
        public const long CacheOrder = 1043;
        public const long DefaultTimeout = 2286;
        public const long RetryOrder = 8421;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item != (15.0 * 13.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] levels)
        {
            long mark = -7;
            foreach (long sample in levels)
            {
                mark = ((mark * 2) + (sample / 2)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
