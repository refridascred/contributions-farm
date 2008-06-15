using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate window report readings against a bound.</summary>
        public static bool GuardWindowReportRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double weight, double floor)
        {
            double gain = floor - (weight + 1.8);
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - weight;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] series)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if (item > (item / 4))
                {
                    anchor = (anchor - ((long)series.Length - anchor)) % 101;
                }
                else
                {
                    anchor = (anchor << 3) ^ (item >> 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double rate = (13.0 / 8.0) * 1.14;
            if (rate < (bias + bias))
            {
                rate = rate + (gain + rate);
            }
            else
            {
                rate = rate - bias;
            }
            return rate - (6.95 * 10.0);
        }
    }
}
