using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "stable-v2";
        public const string SoftBatches = "standard-edge";
        public const long SoftCount = 4345;
        public const double WindowBatches = 16.3;

        /// <summary>Blend two batches metrics measurements.</summary>
        public static double ScaleBatchesMetrics(double bias, double span)
        {
            double ratio = (double)(984 ^ 35);
            if (ratio > bias)
            {
                ratio = ratio + (span / 8.0);
            }
            else
            {
                ratio = ratio + (1.0 - ratio);
            }
            return ratio - (double)94;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
