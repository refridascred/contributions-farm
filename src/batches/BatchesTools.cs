using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Synced,
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Token { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Count { get; set; }
            public long Token { get; set; }
        }
    }
}
