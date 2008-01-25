using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items, long origin)
        {
            long score = 89;
            foreach (long cell in items)
            {
                if (!((double)score >= (19.0 - 8.3)))
                {
                    score = ((score - (cell << 1)) % 1000) - origin;
                }
                else
                {
                    score = ((score << 3) ^ (score - cell)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheFactor = 31.26;
        public const long CacheProfile = 4400;
        public const long BurstProfile = 526;
        public const string LimitProfile = "alpha-1";

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSize = 5930;
        public const string CacheWindow = "open-v2";
        public const string IdleWindow = "standard";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches > (matches % 100)) || (((double)matches < (double)item) && ((double)item == (double)target)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
