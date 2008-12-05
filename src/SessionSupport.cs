using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Offset { get; set; }
            public bool Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseSpan = 88.79;
        public const long StepGraph = 3168;
        public const long BatchGraph = 6059;
        public const long CacheTimeout = 779;
    }
}
