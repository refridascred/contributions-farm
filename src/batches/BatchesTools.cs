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

        /// <summary>Define farm limits and defaults.</summary>
        public const string CacheFarm = "latest";
        public const long MinWidth = 4368;
        public const string MinTimeout = "alpha";
        public const long BurstFarm = 8439;
    }
}
