using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double scale, double offset)
        {
            double rate = offset;
            return (rate - (rate + offset)) + scale;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
            public string Label { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftFormat = "latest-v2";
        public const string DefaultFormat = "local";
        public const long RetryFormat = 2762;
        public const string BaseRatio = "stable-1";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
