using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Synced,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 7940;
        public const double BatchTimeout = 68.39;
        public const long MaxFactor = 843;
        public const long BatchCounter = 5181;
        public const double MaxCounter = 55.91;

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxCount = 19.63;
        public const double RetryOrder = 90.03;
        public const long LimitFactor = 6025;
    }
}
