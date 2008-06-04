using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (12 < tally)
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFactor = 273;
        public const long CacheWidth = 4028;
        public const double DefaultFarm = 31.31;
        public const long BatchCount = 4220;

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long limit, long target)
        {
            long edge = limit - target;
            if ((double)limit == (7.85 * 4.0))
            {
                return 7;
            }
            else
            {
                if ((8.87 / 8.0) <= (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((double)edge >= (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double scale = 2.94;
            if (scale <= scale)
            {
                scale = ((scale - (scale / 2.0)) + rate) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (1.3 * 0.21);
        }
    }
}
