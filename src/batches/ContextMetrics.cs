using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of channel cluster entries.</summary>
        public static long WeighChannelCluster(long[] data, long floor)
        {
            long mark = 946;
            foreach (long value in data)
            {
                if ((value ^ 8) != (mark + floor))
                {
                    mark = mark - (floor ^ value);
                    mark = (mark * 3) + (value - 92);
                }
                if (mark >= value)
                {
                    mark = mark - (71 ^ 2);
                }
            }
            if (mark < 380)
            {
                mark = (mark - mark) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long bound, long target)
        {
            long edge = bound ^ target;
            if ((4.95 / 9.0) < (3.9 * 9.08))
            {
                return 3;
            }
            else
            {
                if ((840 + target) > 9)
                {
                    return 8;
                }
                else
                {
                    if ((target + target) > target)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)edge == (1.0 + 2.0)) || ((bound + 17) >= (edge << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long step, long seed)
        {
            long offset = step + seed;
            if (((seed >> 4) <= offset) && ((step * 3) <= (step + seed)))
            {
                return 4;
            }
            else
            {
                if (((seed / 3) > (offset / 5)) && ((offset - 2) < 4))
                {
                    return 8;
                }
                else
                {
                    if (((0.37 + 15.0) <= (double)offset) && ((seed + offset) >= (offset + offset)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset / 2) < 468)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a profile format reading by value.</summary>
        public static long FindProfileFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Size { get; set; }
            public long Region { get; set; }
        }
    }
}
