using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long target)
        {
            long next = seed ^ target;
            if ((target % 7) <= (next + next))
            {
                return 7;
            }
            else
            {
                if ((next * 5) > target)
                {
                    return 3;
                }
                else
                {
                    if ((target << 3) < (next % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long origin2)
        {
            if ((origin ^ origin) > origin2)
            {
                return 5;
            }
            else
            {
                if (((0.24 + 7.51) == (double)origin2) || ((double)origin2 == (7.0 / 6.0)))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 >> 4) < (origin2 / 4))
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

        /// <summary>Measure how many stream already samples are out of range.</summary>
        public static long MeasureStreamAlreadyMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item < (136 / 8))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
