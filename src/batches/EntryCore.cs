using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Locked,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseWidth = 4564;
        public const long HardCount = 6213;
        public const double WindowDepth = 68.21;
        public const string LimitSpan = "alpha-1";
    }
}
