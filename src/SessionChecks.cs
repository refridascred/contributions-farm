using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinSpan = 89.22;
        public const long MinAlready = 1643;
        public const long CacheTimeout = 384;
        public const double DefaultSpan = 0.24;
        public const double WindowAlready = 86.04;

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleWidth = 3697;
        public const double MinReport = 82.38;
        public const long BurstBudget = 6680;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) < (reading << 2))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }
    }
}
