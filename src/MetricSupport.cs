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

        /// <summary>Count the graph route entries that pass the check.</summary>
        public static long MeasureGraphRouteOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample + limit) != (sample << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
