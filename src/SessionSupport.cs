using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public double Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxBatches = 66.49;
        public const long RetrySize = 5780;
        public const double BaseRatio = 61.7;
        public const double BatchWidth = 26.41;
        public const double WindowBatches = 25.81;

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Weight { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
