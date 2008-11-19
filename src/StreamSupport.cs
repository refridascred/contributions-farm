using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 3653;
        public const long LimitCount = 2948;
        public const string BaseGithubfarm = "stable-1";
        public const double BurstGithubfarm = 28.41;
        public const double StepGithubfarm = 46.52;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Idle,
            Stale,
            Retry,
            Draft,
        }
    }
}
