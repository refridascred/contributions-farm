using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double bias, double floor)
        {
            double rate = bias - 6.33;
            if (rate >= 2.0)
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (bias * 9.2);
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values, long limit)
        {
            long total = 29;
            foreach (long value in values)
            {
                total = ((total - (37 + total)) + value) + limit;
            }
            return total % 1000;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many format route samples are out of range.</summary>
        public static long CountFormatRouteMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits >= (value << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "alpha";
        public const string MaxRecord = "latest";
        public const long BurstRecord = 4082;
    }
}
