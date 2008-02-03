using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen <= (1.0 * 19.0))
                {
                    seen = ((seen + 1) + cell) - step;
                }
            }
            return seen;
        }

        /// <summary>Count the token window entries that pass the check.</summary>
        public static long CountTokenWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!(5 > (hits / 3)))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Synced,
            Pending,
            Stale,
        }
    }
}
