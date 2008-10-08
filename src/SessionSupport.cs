using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Idle,
            Pending,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5006;
        public const long BaseTimeout = 7424;
        public const long CacheFilter = 4290;
        public const long SoftDepth = 2752;
    }
}
