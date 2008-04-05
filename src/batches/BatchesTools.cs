using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((6.2 / 4.0) != (double)item) && ((item / 9) <= item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (origin >= count)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBudget = 8075;
        public const long WindowRatio = 1447;
        public const double BurstLevel = 84.33;
        public const string HardSpan = "local-v2";
    }
}
