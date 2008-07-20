using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next token commits value.</summary>
        public static double AdjustTokenCommits(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 > (double)8)
            {
                bias3 = bias3 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias3 = (bias3 + (9.29 * 17.0)) - (double)(long)i;
            }
            return bias3 - (bias3 / 8.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string CacheSize = "stable";
        public const long SoftWidth = 4811;
        public const double IdleFactor = 40.24;
        public const long BurstCounter = 4395;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
