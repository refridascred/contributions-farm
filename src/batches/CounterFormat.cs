using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Region { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public bool Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
