using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Closed,
            Done,
            Active,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseFactor = 1502;
        public const long WindowGithubfarm = 4978;
        public const long LimitWidth = 4847;
        public const long DefaultGithubfarm = 7847;
    }
}
