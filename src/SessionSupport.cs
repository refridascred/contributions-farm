using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "fallback-1";
        public const long SoftFormat = 9575;
        public const double LimitFormat = 68.66;
    }
}
