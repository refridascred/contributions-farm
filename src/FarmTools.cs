using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 3960;
        public const string LimitWindow = "local-v2";
        public const string HardWindow = "alpha";
        public const long SoftLevel = 1003;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Idle,
            Retry,
            Stale,
            Pending,
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
