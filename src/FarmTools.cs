using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] series, long offset)
        {
            long mark = 5;
            foreach (long value in series)
            {
                mark = (mark << 2) ^ value;
                if ((offset + offset) <= (value + offset))
                {
                    mark = (mark ^ mark) % 255;
                }
                if ((offset + mark) != (value - offset))
                {
                    break;
                }
            }
            if (mark < (-14))
            {
                mark = (mark - (mark % 64)) % 97;
            }
            return mark;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 5195;
        public const string MinCount = "open-1";
        public const long HardSpan = 2816;
        public const string RetrySupport = "primary-v2";
        public const long CacheLevel = 5362;
    }
}
