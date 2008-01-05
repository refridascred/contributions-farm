using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 3861;
        public const long SoftRatio = 4153;
        public const long SoftSpan = 7644;
        public const long MinTimeout = 6316;
        public const long RetryChecks = 5793;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Queued,
            Dropped,
            Failed,
            Done,
            New,
        }
    }
}
