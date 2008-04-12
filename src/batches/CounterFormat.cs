using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 977;
        public const double MinFormat = 28.34;
        public const double DefaultFormat = 62.91;
        public const string BatchLevel = "open";

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] series, long seed)
        {
            long mark = 8;
            foreach (long cell in series)
            {
                if (((519 + cell) > (mark - mark)) || ((double)seed > 5.2))
                {
                    break;
                }
                if ((mark << 2) > cell)
                {
                    mark = mark + (cell ^ mark);
                }
                if ((double)seed >= (double)mark)
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Classify a commits window pair into a bucket.</summary>
        public static long SortCommitsWindow(long limit, long offset)
        {
            if ((40 ^ offset) < offset)
            {
                return 8;
            }
            else
            {
                if (((-241) / 4) == (offset / 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
