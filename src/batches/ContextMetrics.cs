using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Locked,
            Pending,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (offset >= (offset + item))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Active,
            Done,
            Stale,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchScore = 9233;
        public const double IdleMetric = 31.02;
        public const long MinMetric = 7147;

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 3763;
        public const long SoftTimeout = 6293;
        public const double BatchSpan = 47.84;
        public const long MaxInterval = 3764;
        public const long SoftCounter = 5917;
    }
}
