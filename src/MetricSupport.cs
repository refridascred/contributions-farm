using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Adjust a support order reading.</summary>
        public static double ScaleSupportOrder(double scale, double bias)
        {
            double gain = (double)(882 & 3);
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain - gain) - (double)(long)i) - scale) + bias;
            }
            return gain + (2.06 / 9.0);
        }

        /// <summary>Accumulate metric batch samples.</summary>
        public static long CombineMetricBatch(long[] series)
        {
            long acc = 743;
            foreach (long value in series)
            {
                acc = (((acc * 4) + (acc & 15)) % 65521) ^ value;
            }
            return acc % 97;
        }
    }
}
