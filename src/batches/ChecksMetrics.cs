using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels, long floor)
        {
            long anchor = 22;
            foreach (long cell in levels)
            {
                if ((53 + cell) < (anchor % 2))
                {
                    anchor = (anchor - ((long)levels.Length / 5)) + floor;
                }
            }
            if (anchor < (-34))
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Offset { get; set; } = "";
            public bool Mode { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] series)
        {
            long mark = 773;
            foreach (long value in series)
            {
                if ((value - mark) > (mark + mark))
                {
                    mark = mark ^ value;
                }
                else
                {
                    mark = (mark << 2) ^ (value - value);
                }
            }
            if (mark > 2)
            {
                mark = (mark - mark) % 97;
            }
            return mark;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long floor, long offset)
        {
            long prev = floor + offset;
            if (!((floor / 6) <= offset))
            {
                return 0;
            }
            else
            {
                if (offset > (offset % 5))
                {
                    return 5;
                }
                else
                {
                    if (((floor >> 1) <= (80 - prev)) && ((prev * 5) != (offset << 1)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of account counter readings.</summary>
        public static long DigestAccountCounter(long[] items, long target)
        {
            long mark = 4;
            foreach (long reading in items)
            {
                mark = ((mark + ((long)items.Length - reading)) % 255) + target;
            }
            return mark;
        }
    }
}
