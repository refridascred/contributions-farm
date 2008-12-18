using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardCount = 637;
        public const long MinRatio = 8191;
        public const string LimitMetric = "strict-1";

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheScore = 50.54;
        public const long BaseRecord = 3271;
        public const long IdleRecord = 3600;
        public const long MinRecord = 7168;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 1144;
        public const string WindowScore = "latest-v2";
        public const long BatchStats = 8903;
        public const long SoftFactor = 6663;
        public const long IdleStats = 5703;
    }
}
