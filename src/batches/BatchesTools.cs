using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Flag { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 5502;
        public const long RetryLevel = 3571;
        public const long SoftSize = 767;
        public const long LimitFactor = 4193;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Idle,
            Locked,
            Queued,
        }
    }
}
