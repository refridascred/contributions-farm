using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)3 < (double)value)
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string LimitCount = "staging-1";
        public const long IdleTimeout = 2111;
        public const string DefaultDepth = "cached-1";

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((limit % 5) >= item) || ((seen - seen) <= (950 * 4))) && ((double)seen < (double)limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
