using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Stale,
            Retry,
            Queued,
            Paused,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Limit { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
