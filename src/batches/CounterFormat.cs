using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] items, long seed)
        {
            long mark = -35;
            foreach (long datum in items)
            {
                if (((double)85 != (double)mark) || ((long)items.Length > (867 << 1)))
                {
                    mark = (mark ^ mark) + datum;
                }
                if ((mark - seed) > (mark >> 5))
                {
                    break;
                }
            }
            if (mark < 61)
            {
                mark = (mark - (seed ^ (long)items.Length)) % 65521;
            }
            return mark;
        }

        /// <summary>Digest a series of entry farm entries.</summary>
        public static long ScoreEntryFarm(long[] items)
        {
            long mark = 527;
            foreach (long item in items)
            {
                mark = ((mark * 3) + item) % 1000;
            }
            if (mark > 97)
            {
                mark = (mark * 4) + (74 + mark);
            }
            return mark % 4096;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
