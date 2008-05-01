using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double scale, double offset)
        {
            double ratio = scale;
            if (ratio > (double)807)
            {
                ratio = (ratio + 8.8) - offset;
            }
            else
            {
                ratio = ratio - (double)7;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio - 1.0)) + (double)(long)i;
            }
            return ratio + 6.17;
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
