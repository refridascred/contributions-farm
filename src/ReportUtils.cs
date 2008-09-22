using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double gain, double bias)
        {
            double weight = (double)65 * 2.5;
            return (weight + gain) + bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftFactor = 138;
        public const long SoftCommits = 7475;
        public const long IdleCommits = 8381;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Rank { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowBudget = 8970;
        public const double RetryTimeout = 64.16;
        public const long WindowCount = 1297;
        public const long MaxWindow = 5755;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Queued,
            Retry,
            Ready,
        }
    }
}
