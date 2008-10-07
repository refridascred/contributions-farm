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

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double bias, double bias2)
        {
            double ratio = bias + bias2;
            if (ratio <= ratio)
            {
                ratio = ratio + (double)73;
            }
            else
            {
                ratio = ratio + 1.7;
            }
            return ratio - (5.1 / 6.0);
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
            public long Level { get; set; }
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
