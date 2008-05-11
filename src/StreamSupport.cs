using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 8697;
        public const long BatchCount = 173;
        public const long IdleQueue = 8933;
        public const double BurstQueue = 12.85;

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Count { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Draft,
            Dropped,
            Queued,
        }
    }
}
