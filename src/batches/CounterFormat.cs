using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Failed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            New,
            Pending,
            Retry,
        }
    }
}
