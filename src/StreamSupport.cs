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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((datum ^ count) >= (700 + datum))
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
    }
}
