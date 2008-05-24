using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Ready,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Done,
            Pending,
            Retry,
            Locked,
        }
    }
}
