using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Retry,
            Synced,
            Queued,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 2484;
        public const long MaxSpan = 2399;
        public const long MaxWidth = 9203;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public double Label { get; set; }
        }
    }
}
