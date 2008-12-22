using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Draft,
            Closed,
            Pending,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public bool Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Retry,
            Synced,
            Locked,
            Draft,
        }
    }
}
