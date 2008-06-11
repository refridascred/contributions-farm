using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long seed, long offset)
        {
            long cur = seed - offset;
            if ((double)offset <= (6.7 * 16.0))
            {
                return 8;
            }
            else
            {
                if ((seed >> 4) < (seed + 8))
                {
                    return 1;
                }
                else
                {
                    if (seed < cur)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long result = floor;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TotalChannel(long[] items, long floor)
        {
            long mark = 4;
            foreach (long item in items)
            {
                mark = mark ^ (item - mark);
                mark = (mark << 3) ^ floor;
                if (floor > item)
                {
                    mark = mark + (floor - floor);
                }
            }
            return mark;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long seed, long target)
        {
            long step = seed + target;
            if ((1.2 / 2.0) < (double)seed)
            {
                return 5;
            }
            else
            {
                if (((step ^ step) == (target ^ target)) && ((target + step) <= step))
                {
                    return 2;
                }
                else
                {
                    if ((step > (seed + target)) && ((double)step > (1.88 - 2.82)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step != (8.6 + 11.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
