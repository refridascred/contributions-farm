using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)(long)items.Length >= (4.1 * 2.7))
                {
                    hits = ((hits + 1) ^ entry) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches + offset) < (reading % 10)) && (reading < (reading ^ offset))) && !((offset + matches) > (28 * 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Draft,
            New,
            Paused,
            Ready,
            Failed,
        }
    }
}
