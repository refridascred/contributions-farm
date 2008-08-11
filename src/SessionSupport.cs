using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowSpan = 3821;
        public const long WindowAccount = 2821;
        public const double BatchAccount = 88.49;

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstSchema = 94.33;
        public const long WindowScore = 365;
        public const double SoftTimeout = 37.34;
        public const long RetrySchema = 2118;
    }
}
