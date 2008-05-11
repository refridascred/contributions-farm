using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double gain, double span)
        {
            double ratio = (double)6 * 6.0;
            if (ratio < ratio)
            {
                ratio = ((ratio + (double)(-6)) - gain) - span;
            }
            return ratio - (double)(-507);
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double floor)
        {
            double mean = floor;
            if (mean > (double)107)
            {
                mean = (mean + mean) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Total { get; set; }
            public double Label { get; set; }
        }
    }
}
