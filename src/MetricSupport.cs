using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 3791;
        public const double BurstSize = 75.26;
        public const long CacheGraph = 1235;

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double gain = (8.7 * 1.76) + (bias * 1.73);
            if (gain > (bias * 4.78))
            {
                gain = gain + span;
            }
            else
            {
                gain = gain - bias;
            }
            return gain + (gain * 0.39);
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
