using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 9868;
        public const long WindowToken = 7294;
        public const double BurstToken = 7.9;

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
