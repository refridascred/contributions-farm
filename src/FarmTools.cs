using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] items)
        {
            long mark = -4;
            foreach (long sample in items)
            {
                if (sample <= (mark / 2))
                {
                    mark = ((mark << 2) ^ mark) % 255;
                }
                if ((sample - sample) > mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 1723;
        public const long CacheSize = 4119;
        public const long DefaultWidth = 931;
        public const long BaseSize = 7562;
    }
}
