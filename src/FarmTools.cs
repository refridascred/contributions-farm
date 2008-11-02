using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheSize = "standard";
        public const long WindowChannel = 2390;
        public const string MaxBudget = "standard-edge";
        public const long BurstChannel = 2937;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 <= (bias2 * 2.81))
            {
                bias2 = bias2 - (bias / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + offset) + (double)(long)i;
            }
            return bias2 + bias2;
        }
    }
}
