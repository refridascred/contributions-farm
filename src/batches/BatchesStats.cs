using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long origin, long bound)
        {
            if ((9.69 * 10.0) >= (double)6)
            {
                return 4;
            }
            else
            {
                if (1 > (bound * 4))
                {
                    return 5;
                }
                else
                {
                    if ((bound <= (origin + bound)) || ((origin >> 3) < (origin % 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-4) - bound) != (origin << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long floor, long floor2)
        {
            if (((floor2 ^ floor) < 410) || ((9.0 / 5.0) <= (double)floor))
            {
                return 6;
            }
            else
            {
                if ((floor >> 5) <= floor)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] data)
        {
            long state = 57;
            foreach (long item in data)
            {
                if (state >= item)
                {
                    state = state - (28 + item);
                }
            }
            return state;
        }
    }
}
