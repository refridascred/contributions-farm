using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Queued,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 5124;
        public const long LimitScore = 1748;
        public const long WindowTimeout = 4980;
        public const string CacheLevel = "staging-edge";
        public const string LimitBatch = "standard-edge";

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
