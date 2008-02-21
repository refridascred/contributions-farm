using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultFactor = 1298;
        public const long MaxOrder = 2326;
        public const long RetryOrder = 4949;
        public const double CacheSpan = 76.8;
        public const double WindowOrder = 54.0;

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long bound)
        {
            long offset = seed - bound;
            if ((seed >= (bound + offset)) && (bound > (seed - bound)))
            {
                return 1;
            }
            else
            {
                if ((offset < (bound << 1)) && (offset >= (offset - bound)))
                {
                    return 5;
                }
                else
                {
                    if ((bound - seed) != (bound ^ bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((0.67 - 0.1) != (double)bound) || ((7 & 31) > (seed + bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length >> 4) >= (sample + hits))
                {
                    hits = (hits + 2) - limit;
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
