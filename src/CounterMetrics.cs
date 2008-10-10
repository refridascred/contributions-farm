using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 9807;
        public const long BaseCounter = 5466;
        public const long HardSize = 37;
        public const long RetryRatio = 4470;
        public const long HardCounter = 7216;
    }
}
