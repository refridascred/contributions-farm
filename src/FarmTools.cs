using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Stale,
            Dropped,
        }
    }
}
