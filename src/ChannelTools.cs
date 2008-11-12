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

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryBudget = "legacy-v2";
        public const string BurstDepth = "local-v2";
        public const string HardScore = "local-v2";
        public const long HardCommits = 2513;

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
