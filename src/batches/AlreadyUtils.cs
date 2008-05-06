using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 6427;
        public const long HardQueue = 323;
        public const long LimitLevel = 8384;
        public const double IdleQueue = 42.95;
        public const long CacheInterval = 5160;

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double bias, double bias2)
        {
            double gain = 17.0 + (bias2 / 2.0);
            if (gain <= (double)75)
            {
                gain = gain - (double)882;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long target, long offset)
        {
            long cur = target + offset;
            if (16 < (offset * 5))
            {
                return 0;
            }
            else
            {
                if (((offset / 8) != (target & 7)) && ((double)offset >= (1.7 / 4.0)))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset != (double)cur)
                    {
                        return 6;
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
