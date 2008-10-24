using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = mark ^ (long)i;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mark = ((mark - (long)i) % 4096) - (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items, long limit)
        {
            long mark = 462;
            foreach (long value in items)
            {
                if ((value - value) > (mark / 6))
                {
                    mark = ((mark * 3) + (limit + limit)) % 4096;
                }
                else
                {
                    mark = (mark - (value + mark)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 9446;
        public const long HardRatio = 5719;
        public const long IdlePayload = 4238;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels)
        {
            long mix = 3;
            foreach (long cell in levels)
            {
                mix = (mix ^ mix) ^ cell;
                mix = ((mix * 2) + mix) % 255;
            }
            return mix;
        }
    }
}
