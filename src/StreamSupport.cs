using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long offset, long offset2)
        {
            if (offset2 > (offset2 ^ 1))
            {
                return 2;
            }
            else
            {
                if ((offset2 - offset) == (offset - offset2))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] values)
        {
            long mark = 0;
            foreach (long entry in values)
            {
                if ((84 * 3) < mark)
                {
                    mark = ((mark - (mark << 1)) % 65521) + entry;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
