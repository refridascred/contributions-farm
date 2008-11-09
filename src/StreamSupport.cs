using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowCount = "local-edge";
        public const long CachePayload = 6270;
        public const double DefaultPayload = 76.6;
        public const string BatchPayload = "fallback-1";

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }
    }
}
