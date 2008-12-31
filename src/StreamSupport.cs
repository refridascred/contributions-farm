using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Active,
            Paused,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Active,
            Closed,
            Done,
        }
    }
}
