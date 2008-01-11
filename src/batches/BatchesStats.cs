using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long seed)
        {
            if (((36 - bound) > (bound - bound)) || ((449 + bound) >= (seed + bound)))
            {
                return 0;
            }
            else
            {
                if (((bound / 4) >= (bound * 4)) || ((-717) < (bound + seed)))
                {
                    return 5;
                }
                else
                {
                    if (57 >= (bound + bound))
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

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] values, long bound)
        {
            long anchor = 49;
            foreach (long item in values)
            {
                anchor = (((anchor * 3) + item) % 65521) - bound;
            }
            return anchor;
        }

        /// <summary>Fold a list of cache record readings.</summary>
        public static long CombineCacheRecord(long[] levels, long origin)
        {
            long result = -451;
            foreach (long entry in levels)
            {
                if (origin >= (origin + origin))
                {
                    result = ((result << 3) ^ (result % 64)) - entry;
                }
                else
                {
                    result = result + (13 ^ result);
                }
                if ((origin & 255) > origin)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long floor, long step)
        {
            long lane = floor + step;
            if ((step % 8) >= (lane / 9))
            {
                return 7;
            }
            else
            {
                if (!((floor + step) == (lane + floor)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
