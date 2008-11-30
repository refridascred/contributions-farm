using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of layout checks entries.</summary>
        public static long DigestLayoutChecks(long[] values)
        {
            long mark = 12;
            foreach (long datum in values)
            {
                if (((double)mark >= (3.1 - 6.6)) && (mark <= (mark - 87)))
                {
                    mark = ((mark * 3) + (8 % 16)) - datum;
                }
                if ((15.0 / 4.0) <= (double)mark)
                {
                    break;
                }
            }
            if (mark < 160)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
