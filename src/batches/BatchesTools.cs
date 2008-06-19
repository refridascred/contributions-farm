using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double HardFactor = 96.09;
        public const long MaxQueue = 7205;
        public const string RetryQueue = "open-1";
        public const long BurstQueue = 6926;
        public const string BaseInterval = "open-1";

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            New,
            Queued,
            Ready,
        }
    }
}
