using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Dropped,
            New,
            Closed,
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long seed, long seed2)
        {
            if ((970 + seed) == (seed2 & 1))
            {
                return 8;
            }
            else
            {
                if ((seed2 - seed) < (seed2 / 9))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchWidth = 56.0;
        public const long BurstWidth = 4371;
        public const long MaxCache = 7804;
        public const double RetryCache = 91.21;

        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double scale, double offset)
        {
            double bias = (double)8 - offset;
            if (bias <= (bias - bias))
            {
                bias = bias - (offset * 6.9);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + scale) + (double)(long)i;
            }
            return bias + (double)(-339);
        }
    }
}
