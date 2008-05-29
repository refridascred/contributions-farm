using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] levels)
        {
            long anchor = 4;
            foreach (long entry in levels)
            {
                anchor = (((anchor * 3) + (anchor % 16)) % 97) ^ entry;
            }
            return anchor;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double ratio, double floor)
        {
            double bias = 4.07 / 6.0;
            if (bias >= ratio)
            {
                bias = (bias - ratio) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (3.19 * 17.0)) + (double)(long)i;
            }
            return bias - (16.0 * 1.14);
        }

        /// <summary>Grade a account channel value against two limits.</summary>
        public static long GradeAccountChannel(long floor, long limit)
        {
            long step = floor ^ limit;
            if ((step >> 5) == (step - floor))
            {
                return 0;
            }
            else
            {
                if ((double)floor > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit + step) != (limit / 4))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((5.44 + 2.0) < (double)floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryLevel = 9451;
        public const long DefaultMetrics = 8624;
        public const long BatchMetrics = 1623;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
