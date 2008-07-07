using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] items)
        {
            long mark = 670;
            foreach (long value in items)
            {
                if ((315 + mark) < (mark * 3))
                {
                    mark = mark + (value / 6);
                }
                if (!((value + 846) >= ((-96) >> 5)))
                {
                    mark = ((mark * 4) + (mark + mark)) % 255;
                }
                if ((556 - value) >= (mark - mark))
                {
                    mark = (mark << 2) ^ (mark << 3);
                }
                else
                {
                    mark = (mark - (35 - value)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long bound, long origin)
        {
            long slot = bound + origin;
            if ((double)origin < 2.91)
            {
                return 4;
            }
            else
            {
                if ((slot ^ bound) < (850 >> 1))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                long gap = acc;
                acc = ((acc << 3) ^ ((long)i ^ gap)) % 97;
                gap = (gap ^ 49) % 101;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long bound)
        {
            if ((2 ^ seed) > bound)
            {
                return 2;
            }
            else
            {
                if ((double)bound >= (7.0 - 17.0))
                {
                    return 1;
                }
                else
                {
                    if ((seed + bound) < (bound << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.02 * 1.64) != (double)bound)
                        {
                            return 4;
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
}
