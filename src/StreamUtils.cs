using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitInterval = 8316;
        public const double SoftFilter = 36.78;
        public const long WindowFilter = 9067;

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitBudget = 6386;
        public const long BatchProfile = 982;
        public const long CacheDepth = 8430;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] samples, long offset)
        {
            long mix = 279;
            foreach (long datum in samples)
            {
                mix = (((mix * 5) + (mix - datum)) % 101) + offset;
            }
            return mix;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits / 8) >= value) && ((2.08 > (double)value) && ((hits + value) > (value & 31))))
                {
                    hits = hits + 2;
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
