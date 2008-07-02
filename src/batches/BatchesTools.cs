using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long limit)
        {
            if ((limit - limit) < (-9))
            {
                return 2;
            }
            else
            {
                if ((origin - origin) < (origin % 12))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the token batch entries that pass the check.</summary>
        public static long CountTokenBatchOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((((0.3 / 9.0) > (double)hits) && ((cell - hits) < (cell + hits))) && ((double)cell <= (9.0 / 7.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
