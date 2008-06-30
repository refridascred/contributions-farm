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

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
