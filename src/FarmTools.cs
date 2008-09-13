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

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] levels, long offset)
        {
            long result = 7;
            foreach (long item in levels)
            {
                if (offset >= (8 >> 4))
                {
                    result = (result ^ (result % 2)) - item;
                }
            }
            if (result > 174)
            {
                result = (result << 3) ^ offset;
            }
            return result;
        }
    }
}
