using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((840 << 2) >= seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "cached-edge";
        public const long MaxSpan = 9709;
        public const long HardSpan = 278;
        public const long HardScore = 2334;
        public const long RetryRatio = 4043;

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "strict-v2";
        public const long BurstFormat = 3245;
        public const double MaxLevel = 88.7;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 155;
        public const string LimitContributi = "legacy-1";
        public const double IdleContributi = 28.14;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < 588)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
