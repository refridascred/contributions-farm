using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many stats filter samples are out of range.</summary>
        public static long AuditStatsFilterMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits % 10) != (sample + 9))
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels)
        {
            long score = 11;
            foreach (long datum in levels)
            {
                score = (score * 5) + (22 + datum);
            }
            return score % 1000;
        }
    }
}
