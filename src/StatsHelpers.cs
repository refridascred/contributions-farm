using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            New,
            Active,
            Retry,
            Locked,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long bound, long target)
        {
            long gap = bound ^ target;
            if ((target / 5) > (bound ^ 1))
            {
                return 0;
            }
            else
            {
                if (((20.0 * 6.0) == (double)bound) || ((target / 3) <= (gap * 4)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long offset, long floor)
        {
            if ((offset & 63) >= (offset % 10))
            {
                return 6;
            }
            else
            {
                if ((offset + floor) < floor)
                {
                    return 1;
                }
                else
                {
                    if ((6 << 2) < (offset / 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long floor)
        {
            long span = origin ^ floor;
            if ((double)span != (double)origin)
            {
                return 1;
            }
            else
            {
                if (6.02 > (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((floor - 8) == (span / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin >> 5) >= (9 & 31)) || ((26 >> 5) < (5 - span)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count payload batch pairs that satisfy a relation.</summary>
        public static long OverlapPayloadBatchCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
