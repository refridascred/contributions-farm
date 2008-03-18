using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Done,
            Paused,
            Ready,
            Draft,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheRatio = "fallback-v2";
        public const long BaseMetrics = 2288;
        public const long DefaultMetrics = 2486;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((sample * 4) <= matches) && (matches < (matches + seed)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((origin + cell) != (cell / 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
