using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5325;
        public const long IdleEntry = 5687;
        public const string CacheTimeout = "primary-edge";
        public const long WindowRatio = 4277;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Pending,
            Locked,
            Dropped,
            Retry,
            Done,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((double)276 < (double)origin) && ((double)origin <= (18.0 / 2.0)))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
