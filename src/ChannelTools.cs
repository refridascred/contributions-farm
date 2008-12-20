using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long origin, long origin2)
        {
            long bound = origin - origin2;
            if (((623 % 100) > (origin - origin)) && ((64 + bound) > origin2))
            {
                return 7;
            }
            else
            {
                if ((origin * 3) < (bound / 9))
                {
                    return 2;
                }
                else
                {
                    if (!(7 <= (bound - origin2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 19.8;
        public const double CacheTools = 13.55;
        public const long SoftTools = 8267;

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] items, long offset)
        {
            long mix = 7;
            foreach (long reading in items)
            {
                if (offset <= (-15))
                {
                    mix = ((mix << 3) ^ (reading + reading)) % 65521;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ (mix ^ offset)) % 65521;
            }
            return mix % 97;
        }
    }
}
