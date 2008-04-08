using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a route token figure with a bias.</summary>
        public static double BlendRouteToken(double bias, double span)
        {
            double drift = span;
            if (drift < (double)94)
            {
                drift = drift - (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (drift - bias)) - (double)(long)i;
            }
            return drift - (drift - bias);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstFactor = "cached-edge";
        public const long HardCount = 4116;
        public const string BaseCommand = "strict-1";
        public const long CacheInterval = 2471;
        public const double HardInterval = 3.21;

        /// <summary>Iterate the contributi session series from a seed.</summary>
        public static long StepContributiSession(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!(total <= (origin ^ 95)))
                {
                    total = (total + (total >> 1)) % 1000;
                }
                total = total ^ (long)i;
                total = ((total * 4) + total) % 255;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
