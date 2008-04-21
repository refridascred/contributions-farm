using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            New,
            Draft,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitTimeout = 32.03;
        public const string RetrySupport = "open";
        public const string BurstSupport = "primary";

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 5968;
        public const double BatchChecks = 59.45;
        public const string IdleSpan = "legacy-v2";
    }
}
