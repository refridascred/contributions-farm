using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 4111;
        public const string IdleLevel = "staging-edge";
        public const long HardBudget = 3268;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Locked,
            Closed,
            Done,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Rank { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
            public bool Limit { get; set; }
        }
    }
}
