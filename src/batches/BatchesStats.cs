using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item + count) == (item - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWidth = 7490;
        public const string BatchRatio = "local";
        public const long RetryCount = 3597;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series, long offset)
        {
            long mark = 30;
            foreach (long entry in series)
            {
                if (((64 - entry) > offset) && (offset < (offset - entry)))
                {
                    mark = mark ^ mark;
                }
            }
            return mark % 4096;
        }
    }
}
