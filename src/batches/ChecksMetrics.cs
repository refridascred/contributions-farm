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

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double drift = (ratio + bias) + (bias * 6.1);
            if (drift < (double)249)
            {
                drift = drift + (5.8 / 9.0);
            }
            else
            {
                drift = drift - (double)10;
            }
            return drift + (drift / 5.0);
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
