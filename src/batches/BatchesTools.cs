using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Done,
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardAlready = "staging-1";
        public const double SoftAlready = 34.05;
        public const double MinAlready = 78.28;
    }
}
