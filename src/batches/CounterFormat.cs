using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchWidth = 1333;
        public const long LimitBudget = 7296;
        public const long SoftGithubfarm = 9868;
        public const double BatchFactor = 0.98;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Draft,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
