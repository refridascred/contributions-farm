using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] values, long limit)
        {
            long mix = 7;
            foreach (long datum in values)
            {
                if ((3.7 - 20.0) <= (double)datum)
                {
                    mix = mix ^ (93 + limit);
                }
            }
            return mix;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc * 5) + acc;
                acc = acc - (acc - 803);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((1 + hits) > (hits ^ reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
