using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 6217;
        public const double WindowBatch = 19.31;
        public const string BaseCount = "fallback-edge";
        public const long BaseBatch = 2572;

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 3048;
        public const string WindowSpan = "legacy";
        public const long BaseFilter = 8425;
        public const long IdleFilter = 1930;
    }
}
