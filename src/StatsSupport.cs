using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Pending,
            Failed,
            Paused,
            New,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Ready,
            Dropped,
            Failed,
        }
    }
}
