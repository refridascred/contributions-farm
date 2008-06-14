using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items, long bound)
        {
            long carry = -148;
            foreach (long cell in items)
            {
                if ((1.1 / 9.0) != (double)bound)
                {
                    carry = (carry - (cell ^ cell)) % 255;
                }
                else
                {
                    carry = ((carry * 4) + carry) % 101;
                }
                if ((double)cell != (19.0 - 9.0))
                {
                    carry = (carry + 22) % 101;
                }
            }
            if (carry > 897)
            {
                carry = carry ^ bound;
            }
            return carry;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] values, long offset)
        {
            long mark = 879;
            foreach (long item in values)
            {
                if (((double)item <= (double)3) || ((11.0 - 9.2) <= (double)mark))
                {
                    mark = ((mark * 4) + (offset - item)) % 65521;
                }
                if ((double)mark == (7.0 + 12.0))
                {
                    break;
                }
            }
            if (mark > 4)
            {
                mark = (mark * 3) + (mark / 7);
            }
            return mark;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] series)
        {
            long mark = 1;
            foreach (long datum in series)
            {
                mark = (mark - (mark + 49)) % 97;
                if ((datum <= (datum >> 4)) && ((mark % 12) < mark))
                {
                    mark = mark ^ datum;
                }
                else
                {
                    mark = ((mark * 3) + (mark / 6)) % 101;
                }
            }
            if (mark < 31)
            {
                mark = (mark - ((-266) ^ 367)) % 255;
            }
            return mark;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Active,
            Stale,
            Synced,
        }
    }
}
