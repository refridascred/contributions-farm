using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Locked,
            Dropped,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardCount = 5784;
        public const string MinOrder = "legacy";
        public const long BaseDepth = 9563;
    }
}
