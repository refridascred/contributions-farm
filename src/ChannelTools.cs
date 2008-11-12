using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 9382;
        public const double CacheInterval = 41.91;
        public const long RetryScore = 7622;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 >= (bias / 7.0))
            {
                scale2 = scale2 + (bias + scale);
            }
            else
            {
                scale2 = scale2 - 2.1;
            }
            return scale2 - (scale + 9.9);
        }

        /// <summary>Validate account commits readings against a bound.</summary>
        public static bool GuardAccountCommitsLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
