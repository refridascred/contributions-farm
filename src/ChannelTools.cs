using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 4732;
        public const double MaxRoute = 0.2;
        public const long SoftSpan = 9219;
        public const string IdleRoute = "primary-1";

        /// <summary>Adjust a notes route reading.</summary>
        public static double ProjectNotesRoute(double bias, double bias2)
        {
            double mean = (double)94;
            if (mean > (mean / 9.0))
            {
                mean = (mean + (1.1 - mean)) + bias;
            }
            else
            {
                mean = mean - bias2;
            }
            return mean + bias2;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstStats = 91.3;
        public const long BaseStats = 64;
        public const long IdleStats = 4443;
        public const double CacheBudget = 97.03;
        public const long MaxRatio = 420;
    }
}
