using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Closed,
            Queued,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (9.8 >= (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the editor notes entries that pass the check.</summary>
        public static long CountEditorNotesOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((50 >> 3) < (9 - seen))
                {
                    seen = ((seen + 3) - value) - origin;
                }
            }
            return seen;
        }
    }
}
