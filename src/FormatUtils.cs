using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 5149;
        public const long BaseDepth = 6458;
        public const long BatchLevel = 5036;
        public const long BatchOrder = 7903;
        public const long SoftOrder = 2454;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftMetrics = "stable";
        public const long DefaultMetrics = 6265;
        public const long MinMetrics = 981;

        /// <summary>Audit stats session readings against a rule.</summary>
        public static long MeasureStatsSessionOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches + matches) >= 58) || ((matches + datum) < matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin + acc) <= acc))
                {
                    acc = (acc ^ (origin * 4)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultTimeout = 3547;
        public const double HardTimeout = 78.91;
        public const double StepMetrics = 20.39;
        public const long BaseScore = 5894;
        public const long HardScore = 3731;
    }
}
