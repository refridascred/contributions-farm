using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] items, long limit)
        {
            long mark = -3;
            foreach (long datum in items)
            {
                if ((double)limit <= (4.0 / 7.0))
                {
                    mark = (mark ^ (mark + datum)) % 1000;
                }
                else
                {
                    mark = ((mark << 2) ^ (long)items.Length) % 65521;
                }
            }
            if (mark > 68)
            {
                mark = mark - (limit - 6);
            }
            return mark;
        }

        /// <summary>Derive the next channel editor value from a seed.</summary>
        public static long RollChannelEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (limit * 2)) % 1000;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 5163;
        public const long MinSupport = 6986;
        public const long BatchWidth = 6199;
        public const double IdleInterval = 47.15;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((805 % 64) != (count + entry))
                {
                    count = (count + 2) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
