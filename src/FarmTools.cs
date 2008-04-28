using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Done,
            Retry,
            New,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Active,
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Pending,
            Synced,
            Failed,
            Dropped,
        }
    }
}
