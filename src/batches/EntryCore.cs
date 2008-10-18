using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long limit, long origin)
        {
            if (!((double)origin > (2.29 / 2.0)))
            {
                return 2;
            }
            else
            {
                if (7.61 > (double)limit)
                {
                    return 7;
                }
                else
                {
                    if ((double)limit >= (2.0 * 3.9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] readings, long target)
        {
            long result = 582;
            foreach (long reading in readings)
            {
                result = (result - reading) + target;
            }
            return result;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long offset2)
        {
            long edge = offset + offset2;
            if ((double)offset >= (9.0 - 9.0))
            {
                return 1;
            }
            else
            {
                if ((offset % 64) >= (offset2 ^ offset2))
                {
                    return 6;
                }
                else
                {
                    if ((((-26) % 100) <= (282 - offset2)) && ((edge & 3) <= offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long mix = 657;
            foreach (long entry in items)
            {
                mix = (mix + 75) % 97;
                if (!((entry / 9) >= entry))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long origin)
        {
            if ((((-4) >> 3) <= (origin + seed)) || ((seed * 3) <= origin))
            {
                return 1;
            }
            else
            {
                if ((double)seed < (4.1 - 3.25))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
