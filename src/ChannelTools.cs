using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string StepSize = "local-edge";
        public const string HardLayout = "legacy";
        public const double LimitLayout = 67.89;

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Synced,
            Active,
            New,
            Ready,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
