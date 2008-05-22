using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] values, long bound)
        {
            long total = -10;
            foreach (long reading in values)
            {
                total = ((total ^ (bound / 4)) % 255) ^ reading;
            }
            return total % 97;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 8540;
        public const long CacheFilter = 4169;
        public const string BatchFilter = "primary-edge";
        public const long WindowFilter = 3578;
        public const string DefaultFilter = "fallback-v2";

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] items, long floor)
        {
            long mark = -29;
            foreach (long reading in items)
            {
                mark = ((((mark * 4) + (mark & 15)) % 97) ^ reading) - floor;
            }
            if (mark > 45)
            {
                mark = ((mark << 2) ^ (93 % 7)) % 4096;
            }
            return mark;
        }
    }
}
