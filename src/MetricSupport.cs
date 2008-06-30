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

        /// <summary>Validate context account readings against a bound.</summary>
        public static bool ValidateContextAccountRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
