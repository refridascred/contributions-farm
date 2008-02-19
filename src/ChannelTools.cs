using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Stale,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 18.63;
        public const long BatchLevel = 2406;
        public const double RetryFactor = 49.49;
        public const double HardLevel = 42.21;

        /// <summary>Scale a metric farm figure with a bias.</summary>
        public static double SmoothMetricFarm(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= (ratio + bias2))
            {
                ratio = (ratio + ratio) - bias;
            }
            return ratio - (double)(-42);
        }
    }
}
