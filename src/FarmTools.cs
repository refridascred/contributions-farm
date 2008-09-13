using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((reading >> 3) == (hits + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the editor order entries that pass the check.</summary>
        public static long TallyEditorOrderOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen + 77) <= seen)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count - entry) >= count) || !((count + (long)series.Length) != (count * 4)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
