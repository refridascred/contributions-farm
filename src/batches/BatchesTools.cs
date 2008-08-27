using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((floor + sample) <= (floor + seen))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
