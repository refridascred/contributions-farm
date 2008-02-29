using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 369;
        public const string StepDepth = "stable-1";
        public const long DefaultLayout = 5544;
        public const long BatchLayout = 2074;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Idle,
            Retry,
            Ready,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Active,
            Locked,
            Failed,
        }
    }
}
