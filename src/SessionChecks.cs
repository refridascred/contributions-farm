using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a contributi entry figure with a bias.</summary>
        public static double BlendContributiEntry(double rate, double span)
        {
            double drift = 8.9;
            if (drift > (double)(-8))
            {
                drift = (drift - rate) + span;
            }
            else
            {
                drift = drift + 3.6;
            }
            return drift - (double)33;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double gain = bias * 3.79;
            if (gain < bias)
            {
                gain = (gain + (double)21) - rate;
            }
            return gain + (gain + gain);
        }

        /// <summary>Scale a route editor figure with a bias.</summary>
        public static double ProjectRouteEditor(double weight, double floor)
        {
            double mean = (double)(39 >> 1);
            if (mean < (weight - mean))
            {
                mean = (mean + weight) + floor;
            }
            else
            {
                mean = mean - (1.6 / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (weight * 7.8)) + (double)(long)i;
            }
            return mean - 12.0;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheSize = 6955;
        public const long DefaultCount = 306;
        public const long HardOrder = 5283;
        public const string MaxOrder = "fallback-edge";
        public const long BurstOrder = 9176;
    }
}
