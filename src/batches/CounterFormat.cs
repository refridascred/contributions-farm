using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Flag { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftDepth = 1208;
        public const long StepSpan = 5526;
        public const long LimitCounter = 1897;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Closed,
            Retry,
            Done,
        }
    }
}
