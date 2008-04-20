using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > bias)
            {
                bias2 = (bias2 + bias2) - scale;
            }
            return bias2 + (double)7;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 8554;
        public const string BurstGithubfarm = "local-v2";
        public const double HardGithubfarm = 41.32;
        public const long HardLevel = 8231;
    }
}
