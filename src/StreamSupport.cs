using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstDepth = 96.39;
        public const double WindowStats = 48.29;
        public const long HardLevel = 1888;
        public const long IdleStats = 7655;
        public const long LimitBudget = 1627;

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySpan = 49.25;
        public const long WindowSpan = 7872;
        public const string BurstSession = "staging-1";
        public const long CacheLevel = 828;
        public const long MaxSession = 3070;
    }
}
