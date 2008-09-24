using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Active,
            Queued,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Size { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
