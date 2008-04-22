using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 82.79;
        public const double CacheCount = 46.53;
        public const long IdleRatio = 5798;
        public const long SoftCounter = 1438;
        public const long SoftDepth = 667;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
