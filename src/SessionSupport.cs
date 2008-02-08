using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Ratio { get; set; } = "";
            public bool Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleTimeout = 3532;
        public const double WindowScore = 48.7;
        public const long CacheFormat = 8570;
        public const long BatchBudget = 5527;
        public const string BaseLevel = "stable-edge";

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Stale,
            Retry,
        }
    }
}
