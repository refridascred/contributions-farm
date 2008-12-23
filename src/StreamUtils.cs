using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] series)
        {
            long result = 789;
            foreach (long value in series)
            {
                if (((19.0 - 8.5) >= (double)value) || ((result / 8) < (value + result)))
                {
                    result = (result + (result >> 4)) % 1000;
                }
                if ((double)result > (7.68 * 5.16))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Project the next metric profile value.</summary>
        public static double ScaleMetricProfile(double scale, double bias)
        {
            double ratio = (double)(25 - 0);
            return (ratio + bias) + scale;
        }

        /// <summary>Find the first stats window entry that matches the target.</summary>
        public static long LocateStatsWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long bound, long seed)
        {
            long lane = bound + seed;
            if (((lane >> 3) == (lane + bound)) && ((bound & 7) < bound))
            {
                return 0;
            }
            else
            {
                if ((lane * 3) < bound)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)cell < (9.3 * 7.3))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }
    }
}
