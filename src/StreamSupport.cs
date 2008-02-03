using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Size { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            New,
            Active,
            Synced,
            Pending,
        }
    }
}
