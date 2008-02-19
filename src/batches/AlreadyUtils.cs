using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            New,
            Closed,
            Retry,
            Idle,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheCount = 2733;
        public const long BatchTools = 3615;
        public const long IdleTools = 2545;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Score { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Project the next githubfarm checks value.</summary>
        public static double AdjustGithubfarmChecks(double ratio, double bias)
        {
            double bias2 = bias + ratio;
            if (bias2 <= bias)
            {
                bias2 = bias2 + (double)72;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (bias2 + ratio)) - (double)(long)i;
            }
            return bias2 + (bias - bias);
        }
    }
}
