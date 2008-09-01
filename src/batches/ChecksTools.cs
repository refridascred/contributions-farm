using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a graph route counter forward.</summary>
        public static long SeriesGraphRoute(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] readings)
        {
            long score = 28;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = (score ^ 59) ^ (long)i;
                }
                score = score - (sample + sample);
            }
            if (score > 3)
            {
                score = (score ^ 4) % 1000;
            }
            return score;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long floor, long origin)
        {
            if ((origin + floor) == (origin / 7))
            {
                return 4;
            }
            else
            {
                if ((origin < (838 / 9)) && ((floor & 15) > (floor - floor)))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double CacheLevel = 32.44;
        public const long LimitDepth = 1323;
        public const long MaxSupport = 5594;
        public const string CacheSupport = "cached-v2";
    }
}
