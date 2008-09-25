using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long offset, long origin)
        {
            if (!((offset << 2) >= (627 >> 1)))
            {
                return 0;
            }
            else
            {
                if ((offset >> 5) == (origin << 3))
                {
                    return 3;
                }
                else
                {
                    if ((origin % 12) > (origin * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset > (double)origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items)
        {
            long acc = 34;
            foreach (long value in items)
            {
                if ((((long)items.Length + 44) < (acc - value)) && ((value << 3) < 916))
                {
                    acc = ((acc * 4) + (value & 31)) % 65521;
                }
                else
                {
                    acc = (acc << 3) ^ (value + value);
                }
                if (((-7) <= (acc & 127)) || ((acc & 15) <= acc))
                {
                    break;
                }
                else
                {
                    acc = acc ^ value;
                }
                acc = (acc + (73 - 37)) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] readings)
        {
            long total = 6;
            foreach (long value in readings)
            {
                total = (total - (value ^ value)) % 4096;
            }
            return total;
        }
    }
}
