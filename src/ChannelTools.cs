using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultFactor = 1298;
        public const long MaxOrder = 2326;
        public const long RetryOrder = 4949;
        public const double CacheSpan = 76.8;
        public const double WindowOrder = 54.0;

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] levels)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                mark = (mark ^ (mark << 2)) % 1000;
                if ((244 ^ (long)levels.Length) > (mark << 1))
                {
                    mark = ((mark * 3) + (value & 7)) % 255;
                }
                else
                {
                    mark = (mark * 4) + (mark << 2);
                }
            }
            if (mark < 4)
            {
                mark = (mark - mark) % 101;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length >> 4) >= (sample + hits))
                {
                    hits = (hits + 2) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
