using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Weight { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 2642;
        public const double SoftSupport = 45.86;
        public const long HardBudget = 5240;
        public const long IdleInterval = 9493;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
