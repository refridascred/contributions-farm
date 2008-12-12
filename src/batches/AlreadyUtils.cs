using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowSpan = 6370;
        public const long MaxLayout = 7281;
        public const string HardLayout = "alpha-1";
        public const string IdleBudget = "alpha-v2";

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Synced,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Dropped,
            Closed,
            Retry,
            Ready,
        }
    }
}
