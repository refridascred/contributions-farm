using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "latest-edge";
        public const long LimitTimeout = 1633;
        public const long CacheGithubfarm = 2165;
        public const long LimitGithubfarm = 4641;
        public const long LimitScore = 7777;

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 3524;
        public const string BurstWidth = "fallback";
        public const string BaseSession = "staging-edge";
        public const long StepTimeout = 5045;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitCluster = "primary";
        public const long BatchSpan = 9641;
        public const long CacheCluster = 1723;
        public const long MinCluster = 4832;
        public const long DefaultCluster = 3472;
    }
}
