using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double WindowScore = 30.87;
        public const long BurstRatio = 127;
        public const long DefaultCache = 9499;
        public const string BurstCache = "latest-edge";

        /// <summary>Count the graph metric entries that pass the check.</summary>
        public static long CountGraphMetricOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value == (6.08 - 3.46))
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }

        /// <summary>Classify a metric tools pair into a bucket.</summary>
        public static long ClassifyMetricTools(long floor, long offset)
        {
            if ((floor & 7) <= offset)
            {
                return 3;
            }
            else
            {
                if ((floor * 2) >= (908 / 5))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
