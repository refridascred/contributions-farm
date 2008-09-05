using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Active,
            Closed,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitInterval = "open-edge";
        public const double CacheDepth = 55.4;
        public const long BaseTimeout = 1837;
        public const string MinInterval = "open";
    }
}
