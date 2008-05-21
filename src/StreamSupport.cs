using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank already report input into a small class.</summary>
        public static long RankAlreadyReport(long origin, long target)
        {
            if ((target & 7) > (origin + origin))
            {
                return 2;
            }
            else
            {
                if (((8.3 - 3.8) > (double)origin) || (target <= (target / 8)))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LocateQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 49.51;
        public const long CacheCounter = 251;
        public const long BatchScore = 8580;
    }
}
