using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long offset, long limit)
        {
            if ((limit <= (offset - limit)) && ((24 + limit) >= offset))
            {
                return 7;
            }
            else
            {
                if (((offset * 4) <= (offset - (-4))) && ((double)offset > (16.0 * 5.7)))
                {
                    return 6;
                }
                else
                {
                    if (!((offset - offset) != (offset >> 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
