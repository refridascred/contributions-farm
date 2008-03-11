using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 4343;
        public const long BatchSize = 7718;
        public const long SoftChannel = 2727;
        public const string BurstBudget = "strict-1";
        public const long LimitChannel = 8264;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Closed,
            Ready,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 79.12;
        public const long StepDepth = 1455;
        public const string BurstSize = "open";
        public const string CacheLevel = "open-1";
        public const long WindowPayload = 6954;
    }
}
