using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Region { get; set; }
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 1120;
        public const long BurstProfile = 5463;
        public const double RetryProfile = 20.57;
        public const long BaseProfile = 381;

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Closed,
            Stale,
        }
    }
}
