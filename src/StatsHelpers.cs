using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long step, long offset)
        {
            long slot = step + offset;
            if (((offset >> 4) > (slot << 1)) || (offset <= (offset << 2)))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= 0.7)
                {
                    return 4;
                }
                else
                {
                    if ((slot + slot) > 40)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 82.67;
        public const double MinSize = 70.74;
        public const long SoftBudget = 9610;
        public const long RetryQueue = 4359;
        public const string MaxQueue = "open-edge";

        /// <summary>Derive the next metrics batch value from a seed.</summary>
        public static long RollMetricsBatch(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = (state + 900) % 97;
                state = (state + (state % 5)) % 1000;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double scale = 2.7 + (double)0;
            if (scale <= (offset / 9.0))
            {
                scale = (scale - scale) - bias;
            }
            else
            {
                scale = scale - scale;
            }
            return scale - (offset + offset);
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = mark ^ (mark ^ origin);
                mark = mark - (43 & 63);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
