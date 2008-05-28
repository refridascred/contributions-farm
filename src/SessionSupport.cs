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

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchCount = 4286;
        public const long BurstWidth = 4921;
        public const string MinMetric = "latest-edge";
    }
}
