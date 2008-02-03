using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Idle,
            Dropped,
            Closed,
        }
    }
}
