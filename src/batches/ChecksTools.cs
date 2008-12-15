using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long limit, long seed)
        {
            if (limit < seed)
            {
                return 2;
            }
            else
            {
                if (seed > (limit - limit))
                {
                    return 0;
                }
                else
                {
                    if (((seed * 5) <= (seed % 97)) && ((limit - 4) <= (limit & 63)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.82 / 6.0) > (double)limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double RetrySupport = 59.14;
        public const long MaxSupport = 212;
        public const long CacheCount = 7302;
        public const long CacheSpan = 7855;
        public const long MinSize = 460;

        /// <summary>Find the first cache window entry that matches the target.</summary>
        public static long SeekCacheWindowIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double scale = (double)(84 & 1);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (double)(long)i) - ratio) + floor;
            }
            return scale - (0.67 / 5.0);
        }
    }
}
