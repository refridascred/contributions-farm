using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Draft,
            Queued,
        }
    }
}
