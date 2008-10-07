using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the record stream series from a seed.</summary>
        public static long IterateRecordStream(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix * 3) + (mix % 2);
                if ((double)mix < (double)(long)i)
                {
                    mix = (mix << 2) ^ mix;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long offset, long seed)
        {
            if (((double)offset < (9.1 + 16.0)) && ((double)seed >= (6.96 * 8.3)))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (0.7 * 3.69))
                {
                    return 6;
                }
                else
                {
                    if (((offset % 5) < seed) && ((seed - offset) > (seed ^ seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed < (offset ^ 9))
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
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Limit { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long offset2)
        {
            long delta = offset - offset2;
            if ((delta - delta) == (offset << 3))
            {
                return 4;
            }
            else
            {
                if ((offset * 4) > (offset2 & 1))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long offset)
        {
            if (((limit + limit) > (offset % 64)) && ((0 - offset) > offset))
            {
                return 7;
            }
            else
            {
                if ((offset ^ 482) >= offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset < (4 - limit)) && (offset > 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset + offset) < offset)
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
    }
}
