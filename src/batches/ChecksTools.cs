using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Active,
            Dropped,
            New,
            Locked,
            Pending,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitReport = "open";
        public const double LimitTimeout = 18.23;
        public const long CacheReport = 1682;
        public const long DefaultReport = 2741;

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double mean = ratio;
            return (mean - (6.39 * 9.0)) + span;
        }
    }
}
