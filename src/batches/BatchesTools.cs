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

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
