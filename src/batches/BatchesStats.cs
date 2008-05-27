using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits >> 5) <= value)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the already profile entries that pass the check.</summary>
        public static long AuditAlreadyProfileMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((0.94 * 7.0) != (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Count the profile buffer entries that pass the check.</summary>
        public static long AuditProfileBufferGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen / 9) < (58 >> 1))
                {
                    seen = ((seen + 3) - entry) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count ^ count) <= (count & 1))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
