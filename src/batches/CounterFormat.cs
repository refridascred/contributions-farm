using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxSpan = "cached-v2";
        public const string BurstCommits = "strict-edge";
        public const long DefaultRatio = 9400;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Active,
            New,
            Idle,
            Done,
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Draft,
            Ready,
            Queued,
        }
    }
}
