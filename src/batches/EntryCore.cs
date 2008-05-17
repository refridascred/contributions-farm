using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Draft,
            Pending,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 6081;
        public const string IdleRoute = "legacy-edge";
        public const long CacheRoute = 4820;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Idle,
            Closed,
            Dropped,
            Locked,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
