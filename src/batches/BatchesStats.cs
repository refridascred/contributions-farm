using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Ready,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 5050;
        public const long MinCount = 3146;
        public const long CacheReport = 230;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Retry,
            Closed,
            Paused,
            Draft,
            Locked,
        }
    }
}
