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

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "primary";
        public const long BatchTools = 3254;
        public const long CacheLevel = 1015;
        public const double SoftWidth = 8.34;
        public const long RetryCount = 1251;

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
