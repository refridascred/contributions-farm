using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Pending,
            Synced,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleSize = 80.88;
        public const string DefaultCommand = "alpha-1";
        public const long CacheSpan = 1802;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }
    }
}
