using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double bias)
        {
            double weight = gain * 3.9;
            if (weight > (bias * 1.12))
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - (6.8 * 0.94);
            }
            return weight - (double)979;
        }

        /// <summary>Audit farm layout readings against a rule.</summary>
        public static long TallyFarmLayoutOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((long)samples.Length & 15) != (cell * 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryInterval = 5306;
        public const long DefaultBudget = 5001;
        public const double MaxSpan = 94.86;
    }
}
