using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Ready,
            Failed,
        }

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
