using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Done,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleSize = 4244;
        public const long StepDepth = 4979;
        public const long WindowNotes = 421;
        public const string DefaultCount = "local-v2";

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            New,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Ready,
            Paused,
            Queued,
        }
    }
}
