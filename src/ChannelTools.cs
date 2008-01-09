using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double bias)
        {
            double gain = (2.9 - scale) - (bias * 0.53);
            if (gain >= scale)
            {
                gain = gain - 4.45;
            }
            return gain + gain;
        }

        /// <summary>Blend two metrics checks measurements.</summary>
        public static double BlendMetricsChecks(double weight, double floor)
        {
            double scale = weight;
            if (scale < scale)
            {
                scale = scale - (floor / 7.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 7.5) + (double)(long)i;
            }
            return scale + weight;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Failed,
            New,
        }
    }
}
