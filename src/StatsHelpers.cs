using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 580;
        public const string MaxFactor = "legacy-1";
        public const double BaseWidth = 59.92;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long step, long target)
        {
            if ((double)28 != (double)step)
            {
                return 4;
            }
            else
            {
                if ((target * 5) < step)
                {
                    return 6;
                }
                else
                {
                    if (((-44) & 1) <= step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double rate2 = (double)(430 >> 3);
            if (rate2 < floor)
            {
                rate2 = rate2 + (floor - rate2);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 - rate) + (double)(long)i;
            }
            return rate2 + (double)0;
        }

        /// <summary>Derive the next batches contributi value from a seed.</summary>
        public static long IterateBatchesContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 16; i++)
            {
                mark = (mark ^ (680 - 296)) % 101;
                if (21 < bound)
                {
                    mark = mark + (bound << 2);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 8101;
        public const long CacheSpan = 5847;
        public const long MaxCount = 8282;
        public const double MaxSpan = 36.34;
    }
}
