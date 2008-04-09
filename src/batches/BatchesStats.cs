using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Done,
            Closed,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MaxSize = "open-v2";
        public const long StepStats = 5610;
        public const string WindowWidth = "fallback-1";
        public const double RetryInterval = 10.67;
        public const double BaseStats = 29.93;

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "fallback";
        public const string WindowRatio = "alpha-1";
        public const long StepSpan = 204;
        public const long IdleWindow = 4153;
        public const long MaxBudget = 2793;
    }
}
