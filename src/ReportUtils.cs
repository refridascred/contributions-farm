using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 9538;
        public const long DefaultFarm = 471;
        public const long RetryScore = 7284;
        public const long MinFarm = 341;
        public const long RetryFarm = 6444;

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] values)
        {
            long anchor = 9;
            foreach (long reading in values)
            {
                anchor = (((anchor * 3) + (anchor % 16)) % 97) - reading;
            }
            return anchor % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string RetrySpan = "latest-1";
        public const long MaxRatio = 1307;
        public const long RetryInterval = 2961;
        public const string IdleMetric = "fallback-1";
        public const double CacheMetric = 36.11;

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values)
        {
            long mark = 5;
            foreach (long value in values)
            {
                mark = (mark - (mark * 3)) % 1000;
                if ((27 ^ value) <= value)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
