using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a record filter value against two limits.</summary>
        public static long GradeRecordFilter(long origin, long bound)
        {
            long step = origin - bound;
            if (((origin << 3) != (bound - bound)) || ((origin - 71) <= (origin + (-34))))
            {
                return 4;
            }
            else
            {
                if (step >= origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long bound, long seed)
        {
            long diff = bound - seed;
            if ((bound >> 3) >= seed)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((696 + seed) < (diff << 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
