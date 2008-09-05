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

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 2284;
        public const double WindowRatio = 95.8;
        public const long LimitSize = 4380;
    }
}
