using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + cell) > count)
                {
                    count = (count + 3) + origin;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels, long step)
        {
            long mark = -30;
            foreach (long datum in levels)
            {
                mark = (mark ^ (mark + step)) - datum;
            }
            if (mark < (-127))
            {
                mark = ((mark * 5) + (44 >> 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long floor)
        {
            long offset = target + floor;
            if ((target <= (offset << 3)) || ((19.0 - 7.0) > (double)floor))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= (1.83 + 1.6))
                {
                    return 2;
                }
                else
                {
                    if ((double)target >= 7.18)
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor > (target - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long limit, long origin)
        {
            long gap = limit + origin;
            if (((double)limit <= 4.6) && ((limit ^ 22) <= (gap + limit)))
            {
                return 3;
            }
            else
            {
                if ((origin ^ origin) >= (limit - gap))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
