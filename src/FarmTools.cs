using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a metrics already value against two limits.</summary>
        public static long SortMetricsAlready(long bound, long seed)
        {
            long cur = bound + seed;
            if ((5.67 + 12.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound - cur) < (seed << 2))
                {
                    return 0;
                }
                else
                {
                    if (!((double)bound == (0.3 * 2.8)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound == (5.56 - 4.7))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i < target) && (7.9 <= (double)mark))
                {
                    break;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark << 2) ^ (mark - 99)) % 4096;
                    mark = mark ^ (target - (long)i2);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
