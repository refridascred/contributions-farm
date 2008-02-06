using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            New,
            Synced,
            Failed,
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
