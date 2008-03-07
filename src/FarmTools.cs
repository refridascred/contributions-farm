using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double DefaultTimeout = 66.31;
        public const long RetryCommits = 8196;
        public const double IdleCommits = 55.41;
        public const long CacheBudget = 8813;

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i >= (3.0 - 17.0))
                {
                    result = result + seed;
                }
                result = (result ^ 461) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double ratio, double floor)
        {
            double bias = ratio;
            if (bias >= (double)(-960))
            {
                bias = (bias + 6.54) + floor;
            }
            return bias + (double)7;
        }
    }
}
