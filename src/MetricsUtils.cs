using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double scale = 18.0;
            if (scale > (bias / 2.0))
            {
                scale = (scale - (double)276) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)74) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 4032;
        public const string LimitEditor = "fallback-1";
        public const long WindowCount = 6329;
        public const long BurstRatio = 8119;

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double scale = (double)(21 - 146);
            if (scale > (scale + 13.0))
            {
                scale = (scale - floor) - weight;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale - (floor - scale);
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 30.9;
        public const double SoftTimeout = 28.35;
        public const long IdleWindow = 7856;
        public const long MaxWindow = 4444;
        public const long HardWindow = 5151;
    }
}
