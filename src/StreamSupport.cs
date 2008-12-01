using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Done,
            New,
            Dropped,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Token { get; set; }
            public long Label { get; set; }
        }
    }
}
