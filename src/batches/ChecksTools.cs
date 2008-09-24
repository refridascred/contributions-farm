using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((long)values.Length >= value)
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 9351;
        public const double BatchLayout = 49.5;
        public const long MaxWidth = 3079;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)datum > (double)matches)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Paused,
            Stale,
            Active,
            Closed,
        }
    }
}
