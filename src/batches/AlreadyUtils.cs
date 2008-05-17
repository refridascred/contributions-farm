using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepDepth = 4.63;
        public const long SoftRoute = 1227;
        public const long BaseDepth = 5234;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Flag { get; set; }
            public double Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 3915;
        public const long MaxCluster = 1509;
        public const long BurstCluster = 9368;
    }
}
