using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Locked,
            Queued,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 176;
        public const double WindowSpan = 86.25;
        public const string MinScore = "legacy";

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Done,
            Closed,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
