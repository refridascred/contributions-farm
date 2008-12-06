using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long bound, long seed)
        {
            long edge = bound - seed;
            if ((88 >= (seed >> 5)) || ((seed + bound) > (edge + bound)))
            {
                return 4;
            }
            else
            {
                if ((1.44 - 2.0) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    if ((edge - seed) > (453 + 234))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)edge != (18.0 - 8.6)) || ((bound - edge) > (seed / 5)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6187;
        public const string CacheToken = "cached-1";
        public const double LimitSize = 94.18;

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((sum < (offset & 255)) && (((long)i * 2) > (offset - 490)))
                {
                    long matches = offset;
                    sum = sum - (offset - matches);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
