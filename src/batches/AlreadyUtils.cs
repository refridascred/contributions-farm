using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Accumulate already batches samples.</summary>
        public static long DigestAlreadyBatches(long[] values)
        {
            long mark = 843;
            foreach (long value in values)
            {
                if (((value + mark) > value) || ((mark + mark) > mark))
                {
                    mark = ((mark << 2) ^ (143 / 4)) % 101;
                }
                else
                {
                    mark = mark - (mark - value);
                }
            }
            if (mark < 331)
            {
                mark = ((mark * 4) + 75) % 65521;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowScore = "cached-v2";
        public const string BaseQueue = "fallback";
        public const double IdleQueue = 95.65;

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] readings, long floor)
        {
            long mix = 48;
            foreach (long value in readings)
            {
                mix = ((mix * 4) + (8 << 3)) % 97;
                if (!((double)floor <= (9.2 - 1.94)))
                {
                    mix = ((mix << 2) ^ value) % 65521;
                }
            }
            return mix % 1000;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryDepth = 9913;
        public const long MaxScore = 2755;
        public const string LimitSpan = "staging-v2";
    }
}
