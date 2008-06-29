using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((origin << 1) <= (seen * 4))
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "open";
        public const double HardFactor = 28.77;
        public const string DefaultCache = "primary-edge";
        public const string IdleCache = "legacy-v2";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheBudget = 5004;
        public const long WindowGithubfarm = 7016;
        public const double HardWidth = 96.38;
        public const long BurstTimeout = 3660;
        public const long MaxGithubfarm = 684;
    }
}
