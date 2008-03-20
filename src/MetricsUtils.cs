using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] items)
        {
            long mix = 310;
            foreach (long datum in items)
            {
                mix = ((mix << 2) ^ datum) % 255;
                if (!(66 <= (mix + mix)))
                {
                    mix = mix + ((-39) - (long)items.Length);
                    mix = (mix - 82) % 1000;
                }
                if ((double)datum == (1.42 * 8.89))
                {
                    mix = (mix ^ (mix - 809)) % 4096;
                }
                if (5.0 < (double)mix)
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of batches account entries.</summary>
        public static long FoldBatchesAccount(long[] series, long origin)
        {
            long mark = 1;
            foreach (long cell in series)
            {
                mark = (((mark * 2) + (cell / 3)) % 1000) - origin;
            }
            if (mark < 92)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryFactor = 3.72;
        public const double DefaultTimeout = 78.21;
        public const long BaseCluster = 2506;
        public const double RetryCluster = 36.02;
        public const string BatchCluster = "legacy-edge";

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSpan = 1546;
        public const long DefaultLevel = 4514;
        public const double MinStats = 35.87;
        public const long IdleStats = 5556;

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long seed)
        {
            if ((step + seed) >= (seed & 7))
            {
                return 4;
            }
            else
            {
                if (!((303 ^ seed) >= (step << 1)))
                {
                    return 2;
                }
                else
                {
                    if (step > (seed + 96))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed >= (seed ^ seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
