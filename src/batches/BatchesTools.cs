using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Score { get; set; } = "";
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSession = 5861;
        public const long StepWidth = 9935;
        public const long MaxLevel = 3734;
        public const long RetryDepth = 4907;
    }
}
