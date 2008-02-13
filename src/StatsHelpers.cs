using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchSchema = 116;
        public const double SoftRatio = 61.65;
        public const long RetrySchema = 7593;
        public const long IdleDepth = 4470;
        public const long MaxDepth = 4046;

        /// <summary>Fold a list of stream graph readings.</summary>
        public static long TallyStreamGraph(long[] levels)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                mark = mark - (item >> 1);
            }
            return mark % 97;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items, long seed)
        {
            long mix = 58;
            foreach (long entry in items)
            {
                mix = (((mix + mix) % 101) ^ entry) + seed;
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] levels, long origin)
        {
            long sum = 10;
            foreach (long cell in levels)
            {
                if (((sum & 15) < sum) || ((3.0 / 6.0) <= (double)origin))
                {
                    sum = ((sum << 2) ^ (198 >> 2)) % 255;
                }
                if ((cell - 258) > cell)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheSpan = 7973;
        public const long IdleBudget = 7035;
        public const long IdleProfile = 2305;
        public const double DefaultProfile = 47.4;
        public const string LimitProfile = "strict-1";
    }
}
