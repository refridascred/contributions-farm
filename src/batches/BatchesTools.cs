using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 596;
        public const string StepFactor = "standard-v2";
        public const long MaxDepth = 8752;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Failed,
            Done,
        }
    }
}
