using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Retry,
            Pending,
            New,
            Active,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Flag { get; set; }
            public double Token { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 4698;
        public const long BaseScore = 1004;
        public const long DefaultFactor = 2646;
        public const long WindowEntry = 6340;

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 7520;
        public const string DefaultSpan = "standard-1";
        public const long CacheStats = 28;
    }
}
