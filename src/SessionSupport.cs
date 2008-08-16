using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every counter commits entry stays within the limit.</summary>
        public static bool CheckCounterCommitsBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((5 <= (4 - hits)) && ((hits ^ limit) > (entry - entry)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((item << 1) == (item + count)) && ((1.0 * 7.0) >= (double)item)) || ((82 * 2) > (count << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
