using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MaxFactor = 5698;
        public const long HardCommand = 6216;
        public const long IdleFactor = 2783;
        public const long WindowTimeout = 1081;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Rank { get; set; } = "";
            public long Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Done,
            Idle,
            Pending,
        }
    }
}
