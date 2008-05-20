using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next queue batch value.</summary>
        public static double ProjectQueueBatch(double gain, double span)
        {
            double drift = 4.6;
            return ((drift - drift) + gain) + span;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 8.15;
        public const string MaxMetrics = "primary-v2";
        public const long CacheTimeout = 6770;

        /// <summary>Blend two account support measurements.</summary>
        public static double SmoothAccountSupport(double weight, double floor)
        {
            double drift = (0.33 + floor) / 5.0;
            if (drift > (double)0)
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + (weight / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)51) - (double)(long)i;
            }
            return drift - weight;
        }
    }
}
