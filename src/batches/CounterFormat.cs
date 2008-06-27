using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading << 2) <= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseWidth = 45.5;
        public const string BaseSession = "fallback";
        public const long MaxSize = 52;
        public const string WindowTimeout = "cached";
        public const double MinSize = 55.5;

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryWidth = 80.93;
        public const double CacheRatio = 14.98;
        public const double MinInterval = 98.15;
    }
}
