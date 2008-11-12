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

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Locked,
            Pending,
            Synced,
            Active,
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
