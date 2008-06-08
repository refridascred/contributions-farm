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

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 1093;
        public const long WindowPayload = 2780;
        public const long MaxDepth = 2092;
        public const long BatchPayload = 4468;

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
