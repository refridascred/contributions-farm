using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Ratio { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Queued,
            Done,
            Draft,
            Locked,
            Stale,
        }
    }
}
