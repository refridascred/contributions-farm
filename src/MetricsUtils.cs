using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                if (origin > 746)
                {
                    total = (total ^ (4 / 6)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double scale, double floor)
        {
            double drift = (double)(3 ^ 86);
            return ((drift - (double)7) + scale) + floor;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double ratio, double floor)
        {
            double gain = (floor + floor) - (floor + floor);
            return gain + ratio;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double floor)
        {
            double weight = (floor / 8.0) * 6.33;
            if (weight >= (floor / 7.0))
            {
                weight = (weight + floor) + bias;
            }
            else
            {
                weight = weight - 16.0;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (weight / 8.0)) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "standard-1";
        public const long BurstInterval = 3635;
        public const double RetryRatio = 7.46;
    }
}
