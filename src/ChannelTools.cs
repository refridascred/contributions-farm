using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            New,
            Closed,
            Pending,
            Active,
            Done,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Draft,
            Locked,
            New,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
