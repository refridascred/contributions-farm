using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Pending,
            Retry,
            Queued,
            Synced,
        }
    }
}
