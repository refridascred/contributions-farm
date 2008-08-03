using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum ^ hits) != (hits - hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches >= (1.48 + 15.0))
                {
                    matches = ((matches + 1) + entry) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Retry,
            Closed,
            Queued,
        }
    }
}
