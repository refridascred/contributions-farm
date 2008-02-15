using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (!((value + seen) == (seen - value)) || ((value - seen) < (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxSpan = 4829;
        public const long LimitLevel = 3376;
        public const double RetryEditor = 73.05;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Locked,
            Retry,
            Ready,
            Failed,
            Idle,
        }
    }
}
