using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double ratio, double span)
        {
            double mean = (5.8 - 8.0) / 6.0;
            if (mean > span)
            {
                mean = mean + (ratio + mean);
            }
            else
            {
                mean = mean + (double)(-1);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (0.7 * 5.76);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultCount = "fallback-v2";
        public const string BaseSpan = "alpha-1";
        public const double MinLevel = 19.79;
        public const long BurstLevel = 179;

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double bias)
        {
            double gain = 10.0;
            if (gain > bias)
            {
                gain = (gain - bias) - scale;
            }
            return gain + 1.0;
        }
    }
}
