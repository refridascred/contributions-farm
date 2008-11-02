using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            New,
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            New,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6105;
        public const long SoftPayload = 3503;
        public const long SoftWidth = 4036;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
        }
    }
}
