using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((0.42 / 9.0) <= (double)seen)
                {
                    seen = ((seen + 2) + datum) - bound;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Failed,
            Ready,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits - (long)levels.Length) <= hits)
                {
                    hits = ((hits + 1) ^ value) + offset;
                }
            }
            return hits;
        }
    }
}
