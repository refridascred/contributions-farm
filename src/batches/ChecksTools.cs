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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxInterval = 9615;
        public const long MaxTimeout = 5177;
        public const long HardCommits = 5407;

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
