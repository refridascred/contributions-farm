using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Draft,
            Dropped,
            Paused,
        }
    }
}
