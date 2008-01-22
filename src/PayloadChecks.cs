using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double scale = bias + (floor - floor);
            if (scale > 0.9)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale - (double)2;
            }
            return scale - (bias + bias);
        }

        /// <summary>Count order context pairs that satisfy a relation.</summary>
        public static long MatchOrderContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 8187;
        public const long BaseMetric = 7268;
        public const long BaseFactor = 4372;
        public const long MinSize = 9454;
        public const string WindowMetric = "fallback";

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long origin, long bound)
        {
            long lane = origin ^ bound;
            if ((origin ^ origin) != (origin / 8))
            {
                return 6;
            }
            else
            {
                if ((2 + bound) == (bound - origin))
                {
                    return 7;
                }
                else
                {
                    if (!((origin * 2) < (lane & 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - origin) < origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] levels)
        {
            long mix = 9;
            foreach (long cell in levels)
            {
                if ((cell + cell) < (17 * 5))
                {
                    mix = ((mix << 3) ^ (mix & 3)) % 101;
                }
                if ((cell * 2) != (mix ^ mix))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
