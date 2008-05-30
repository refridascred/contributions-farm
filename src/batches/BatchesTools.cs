using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((11.0 - 11.0) > (double)reading)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long offset, long origin)
        {
            if (((573 & 31) == (offset / 4)) || (origin >= (origin - offset)))
            {
                return 4;
            }
            else
            {
                if (((9.8 - 1.9) > (double)offset) || ((1.0 + 9.1) <= (double)origin))
                {
                    return 0;
                }
                else
                {
                    if (origin <= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 6) <= (origin * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
