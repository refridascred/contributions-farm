using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double span)
        {
            double drift = 11.0;
            if (drift <= (drift / 4.0))
            {
                drift = (drift + span) + bias;
            }
            else
            {
                drift = drift - (double)518;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift + (double)62;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen ^ seen) > (seen + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxFactor = 3759;
        public const string HardBatch = "primary-1";
        public const double IdleBatch = 31.64;
        public const long CacheLevel = 6475;
        public const long MinBatch = 8353;
    }
}
