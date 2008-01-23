using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseFactor = 194;
        public const long MinSpan = 3275;
        public const long SoftContributi = 2359;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
