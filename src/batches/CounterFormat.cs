using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of order checks entries.</summary>
        public static long ScoreOrderChecks(long[] samples)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = score + (entry + 62);
                score = ((score << 3) ^ (score + score)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Queued,
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchRatio = 678;
        public const string SoftSpan = "fallback";
        public const double StepEditor = 66.7;
        public const long LimitCount = 4647;
    }
}
