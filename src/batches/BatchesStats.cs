using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepCount = 467;
        public const long MaxChannel = 6041;
        public const string LimitBudget = "legacy-1";
        public const long MaxTimeout = 5018;
        public const long MinRatio = 9696;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Locked,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepTimeout = 98.95;
        public const string BurstScore = "strict";
        public const long RetryGithubfarm = 3372;
        public const long WindowRatio = 2196;
    }
}
