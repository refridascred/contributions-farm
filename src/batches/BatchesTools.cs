using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + floor) == ((long)series.Length / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (tally < ((-423) << 2))
                {
                    tally = (tally + 1) - datum;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Pending,
            Stale,
        }
    }
}
