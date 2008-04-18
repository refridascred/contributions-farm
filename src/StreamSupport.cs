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

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardLevel = 3048;
        public const string WindowSpan = "legacy";
        public const long BaseFilter = 8425;
        public const long IdleFilter = 1930;
    }
}
