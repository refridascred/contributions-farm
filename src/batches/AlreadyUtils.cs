using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many stream notes samples are out of range.</summary>
        public static long TallyStreamNotesMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((limit * 3) >= (limit - entry)) && (((entry - count) == (273 << 3)) || ((double)limit <= (double)entry)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 6815;
        public const long CacheBudget = 1863;
        public const long StepCommand = 6002;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Closed,
            Retry,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            New,
            Paused,
            Retry,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Idle,
            Ready,
        }
    }
}
