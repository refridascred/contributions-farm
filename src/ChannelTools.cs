using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Queued,
            Done,
            Draft,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchWidth = 8096;
        public const long SoftDepth = 8716;
        public const long BaseSpan = 6165;
        public const double CacheBudget = 90.0;
        public const long HardBatches = 720;
    }
}
