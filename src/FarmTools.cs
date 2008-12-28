using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit githubfarm farm readings against a rule.</summary>
        public static long CountGithubfarmFarmMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((seen >> 3) >= seen) && ((item % 24) <= floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double rate, double bias)
        {
            double bias2 = 3.39;
            for (int i = 0; i < 7; i++)
            {
                bias2 = ((bias2 - (bias2 + bias)) + (double)(long)i) - rate;
            }
            return bias2 + 6.6;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 899;
        public const string WindowSize = "fallback-v2";
        public const string CacheGithubfarm = "primary-v2";
    }
}
