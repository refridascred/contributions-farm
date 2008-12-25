using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Idle,
            Done,
            Stale,
        }
    }
}
