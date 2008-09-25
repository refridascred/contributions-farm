using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Draft,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstDepth = 4444;
        public const long RetryPayload = 9907;
        public const long BasePayload = 4899;
    }
}
