using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a order entry reading by value.</summary>
        public static long LocateOrderEntryIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheLevel = "fallback-edge";
        public const long MaxAccount = 5658;
        public const double SoftRatio = 41.75;
        public const long RetryAccount = 9041;
        public const double LimitRatio = 66.43;
    }
}
