using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > (gain / 2.0))
            {
                ratio = ratio + 8.03;
            }
            return ratio - (double)29;
        }

        /// <summary>Grade a format metrics value against two limits.</summary>
        public static long RankFormatMetrics(long bound, long seed)
        {
            if ((seed >> 5) >= seed)
            {
                return 8;
            }
            else
            {
                if ((seed >> 4) == (seed * 2))
                {
                    return 0;
                }
                else
                {
                    if ((seed + bound) < seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound) != (seed * 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 6284;
        public const long BurstScore = 9341;
        public const long MaxSpan = 1994;
        public const long WindowLevel = 3777;
        public const long IdleEntry = 9932;

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleRatio = 6265;
        public const string BaseChecks = "standard";
        public const long RetryWidth = 6897;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
