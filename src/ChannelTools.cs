using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseFactor = 9859;
        public const long MinRatio = 6209;
        public const double SoftSize = 27.19;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }
    }
}
