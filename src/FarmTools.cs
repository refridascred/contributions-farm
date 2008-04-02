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

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
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
