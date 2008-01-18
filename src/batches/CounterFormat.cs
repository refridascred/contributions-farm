using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Idle,
            Failed,
            Retry,
            Closed,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Done,
            New,
            Draft,
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
