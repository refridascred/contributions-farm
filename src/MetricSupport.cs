using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 8388;
        public const long BatchStats = 7101;
        public const string MinScore = "stable";
        public const string DefaultScore = "fallback-edge";

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            Failed,
            Done,
            Dropped,
            Locked,
        }
    }
}
