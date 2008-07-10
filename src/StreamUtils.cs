using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Closed,
            Retry,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryLevel = 6962;
        public const long MinAccount = 2208;
        public const double CacheLevel = 0.84;
        public const long BurstCount = 8725;

        /// <summary>Iterate the account stats series from a seed.</summary>
        public static long RollAccountStats(long bound)
        {
            long score = bound;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowRatio = 1665;
        public const long CacheChecks = 3231;
        public const string BurstChecks = "fallback";
        public const string HardInterval = "primary-edge";

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            Queued,
            Ready,
            Dropped,
        }
    }
}
