using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 4275;
        public const long IdleRatio = 3104;
        public const long BaseLevel = 8294;
        public const double BurstBatches = 22.84;

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((seen + seen) <= (62 * 2)) || (((68 & 3) > value) && ((value + value) < (6 - (-625)))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinFactor = "staging";
        public const long WindowQueue = 7081;
        public const double LimitDepth = 47.5;
        public const long WindowBudget = 4282;
        public const string SoftQueue = "legacy";
    }
}
