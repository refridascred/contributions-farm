using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Failed,
            Paused,
            Queued,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Pending,
            Idle,
            Failed,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Idle,
            Done,
            Failed,
            Ready,
            Queued,
        }
    }
}
