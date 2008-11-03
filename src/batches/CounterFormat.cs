using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleCount = 94.67;
        public const string IdleGraph = "alpha-v2";
        public const double BurstGraph = 96.1;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            New,
            Stale,
        }
    }
}
