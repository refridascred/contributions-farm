using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftTimeout = 67.2;
        public const long BatchCache = 1208;
        public const double BurstSize = 3.59;

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double scale, double offset)
        {
            double drift = 15.0;
            if (drift <= (scale + drift))
            {
                drift = drift + (offset * 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + scale) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Adjust a filter metric reading.</summary>
        public static double ScaleFilterMetric(double ratio, double span)
        {
            double bias = span * 1.9;
            if (bias < (double)(-625))
            {
                bias = bias - (ratio + bias);
            }
            return bias + 2.0;
        }
    }
}
