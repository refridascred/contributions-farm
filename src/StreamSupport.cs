using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Active,
            Synced,
            Pending,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 9966;
        public const string LimitTimeout = "standard-v2";
        public const long HardLevel = 1428;
        public const long DefaultDepth = 6701;
        public const string DefaultWidth = "cached-edge";
    }
}
