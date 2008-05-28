using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "local-1";
        public const long BurstCounter = 6544;
        public const string CacheDepth = "strict";
        public const long MinScore = 4923;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Done,
            Locked,
            Stale,
        }

        /// <summary>Validate session token readings against a bound.</summary>
        public static bool GuardSessionTokenLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
