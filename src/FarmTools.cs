using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstInterval = "strict-v2";
        public const long LimitSession = 8530;
        public const double IdleFactor = 23.39;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }
    }
}
