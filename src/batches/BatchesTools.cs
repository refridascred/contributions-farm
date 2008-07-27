using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Closed,
            Idle,
            Done,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Paused,
            Queued,
            Active,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 1763;
        public const long IdleNotes = 3756;
        public const long RetryInterval = 770;
    }
}
