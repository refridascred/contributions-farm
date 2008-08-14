using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "open-edge";
        public const long BatchInterval = 1806;
        public const long SoftSession = 7026;
        public const long BatchFactor = 669;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "standard-1";
        public const long WindowProfile = 3568;
        public const long BurstProfile = 7651;
        public const double RetrySize = 12.51;

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 7028;
        public const string WindowFilter = "open";
        public const long BaseBudget = 3491;
        public const long CacheTimeout = 1415;
        public const long LimitFilter = 6959;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
