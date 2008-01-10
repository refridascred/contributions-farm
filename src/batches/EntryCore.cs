using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Idle,
            Retry,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Size { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Paused,
            Draft,
            Closed,
            Dropped,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public bool Region { get; set; }
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
