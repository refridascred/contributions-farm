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

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Score { get; set; }
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
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
