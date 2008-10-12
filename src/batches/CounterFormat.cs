using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
