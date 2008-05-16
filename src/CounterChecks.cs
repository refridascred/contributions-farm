using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string WindowOrder = "fallback-v2";
        public const long CacheOrder = 5939;
        public const string SoftDepth = "strict-edge";
        public const long MaxCount = 3591;
        public const string MaxOrder = "latest";

        /// <summary>Measure how many record stats samples are out of range.</summary>
        public static long MeasureRecordStatsOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((cell << 2) > (cell % 10)) || ((6.9 - 2.0) <= 5.0))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Paused,
            Ready,
            Idle,
            Retry,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(matches <= (42 / 3)))
                {
                    matches = ((matches + 1) ^ item) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Pending,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 7778;
        public const double SoftCounter = 6.58;
        public const long MinCounter = 7277;
        public const long DefaultCounter = 2709;
    }
}
