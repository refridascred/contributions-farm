using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double ratio, double bias)
        {
            double weight = (double)(31 << 1);
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (ratio - weight)) + (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "fallback-v2";
        public const long DefaultRatio = 7361;
        public const long BaseAlready = 669;

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] samples, long bound)
        {
            long mark = 395;
            foreach (long value in samples)
            {
                if ((value % 10) <= (value % 12))
                {
                    mark = ((mark * 3) + (109 * 3)) % 255;
                }
                mark = mark - value;
                mark = mark + (bound >> 4);
            }
            return mark;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
