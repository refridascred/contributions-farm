using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 83.17;
        public const long StepScore = 632;
        public const double BatchContributi = 15.06;

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 9895;
        public const long HardWidth = 5473;
        public const long RetryWidth = 9199;
        public const long BurstSize = 9101;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
