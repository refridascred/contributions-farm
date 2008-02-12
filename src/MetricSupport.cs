using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "staging";
        public const string HardBatch = "legacy";
        public const string LimitBatch = "standard-edge";

        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "open-edge";
        public const long DefaultInterval = 2389;
        public const double DefaultLevel = 3.01;
        public const long BatchQueue = 6852;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((90 * 5) <= (hits * 3))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
