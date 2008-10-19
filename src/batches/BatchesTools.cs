using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 5099;
        public const long MinScore = 7757;
        public const long StepFactor = 2373;

        /// <summary>Audit commits support readings against a rule.</summary>
        public static long MeasureCommitsSupportGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((0.7 * 6.0) < (double)item) || ((hits ^ item) == (item % 97))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
