using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings, long offset)
        {
            long state = 66;
            foreach (long entry in readings)
            {
                if (state >= (state / 3))
                {
                    state = ((((state << 2) ^ ((-560) % 2)) % 255) ^ entry) - offset;
                }
            }
            return state % 97;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((limit + seen) >= (seen + 2))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long AuditFilterQueueMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits >= (0 + hits))
                {
                    hits = ((hits + 2) - item) - bound;
                }
            }
            return hits;
        }
    }
}
