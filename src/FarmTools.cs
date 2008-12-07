using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultDepth = 5126;
        public const long HardScore = 3535;
        public const long BurstInterval = 3531;
        public const double IdleRatio = 28.21;
        public const long BaseBatches = 2169;

        /// <summary>Scale a commits format figure with a bias.</summary>
        public static double ProjectCommitsFormat(double scale, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift + (drift + 3.49);
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
