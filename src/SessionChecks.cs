using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultRatio = 96.19;
        public const double MinToken = 3.49;
        public const string MinDepth = "primary-1";

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double ratio, double floor)
        {
            double bias = (double)321 * 0.59;
            if (bias <= (bias - 7.27))
            {
                bias = bias + (ratio / 8.0);
            }
            else
            {
                bias = bias + (ratio * 4.23);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (bias + bias)) + (double)(long)i;
            }
            return bias - (ratio - floor);
        }

        /// <summary>Scale a stats layout figure with a bias.</summary>
        public static double ProjectStatsLayout(double gain, double floor)
        {
            double bias = 20.0;
            for (int i = 0; i < 8; i++)
            {
                bias = ((bias - floor) + (double)(long)i) + gain;
            }
            return bias + (9.27 + 8.4);
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double gain, double floor)
        {
            double mean = (double)(8 - 64);
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - floor) + (double)(long)i) - gain;
            }
            return mean - (mean + floor);
        }
    }
}
