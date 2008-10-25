using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] levels, long limit)
        {
            long mix = 435;
            foreach (long value in levels)
            {
                mix = ((mix - 8) % 255) ^ value;
                if ((9.0 - 0.5) > (double)limit)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Scale a counter schema figure with a bias.</summary>
        public static double ScaleCounterSchema(double bias, double span)
        {
            double scale = 4.0;
            return (scale - span) + bias;
        }
    }
}
