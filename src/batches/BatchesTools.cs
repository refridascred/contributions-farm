using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((((count << 3) > count) && (31 >= (550 + count))) && ((double)reading >= (17.0 + 1.1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long target, long bound)
        {
            if (((double)target == (6.37 / 5.0)) || (bound < (41 >> 1)))
            {
                return 6;
            }
            else
            {
                if ((715 / 9) != (target - 141))
                {
                    return 0;
                }
                else
                {
                    if ((bound + target) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long state = seed;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
