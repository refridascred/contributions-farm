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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (tally > 6)
                {
                    tally = ((tally + 2) ^ value) - target;
                }
            }
            return tally;
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

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
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
