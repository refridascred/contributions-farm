using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "standard-1";
        public const double HardStream = 24.98;
        public const string StepStream = "standard-v2";
        public const double BatchBudget = 43.75;
        public const double BaseStream = 49.53;

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
