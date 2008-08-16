using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 6124;
        public const long RetrySession = 9959;
        public const double HardSession = 37.44;
        public const double BatchSession = 78.73;
        public const long StepInterval = 4802;

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Region { get; set; }
            public double Level { get; set; }
        }
    }
}
