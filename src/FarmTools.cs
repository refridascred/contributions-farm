using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitSchema = "cached-v2";
        public const double BaseSchema = 11.52;
        public const string BurstSize = "latest";
        public const string CacheSchema = "strict-1";
        public const double RetryLevel = 4.8;

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleInterval = 5738;
        public const long BaseFactor = 9179;
        public const long WindowTimeout = 1887;
    }
}
