using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public string Level { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Dropped,
            Queued,
        }
    }
}
