using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
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
