using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 4109;
        public const string IdleBatch = "fallback";
        public const double MinBatch = 40.88;
        public const string SoftDepth = "stable-edge";
        public const double RetryRatio = 25.97;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Retry,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
