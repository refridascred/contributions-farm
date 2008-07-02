using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 4624;
        public const double DefaultBatches = 14.55;
        public const long DefaultFactor = 3895;
        public const long CacheBatches = 7965;

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
