using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Draft,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 5758;
        public const long BurstMetric = 4810;
        public const long CacheMetric = 9191;
        public const double CacheBudget = 84.11;
        public const string BatchBudget = "primary-v2";

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double rate, double bias)
        {
            double drift = bias / 5.0;
            if (drift < (rate * 7.9))
            {
                drift = drift + (drift - rate);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - (double)4;
        }
    }
}
