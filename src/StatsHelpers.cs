using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every layout record entry stays within the limit.</summary>
        public static bool CheckLayoutRecordRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long CountChecksLayoutMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((9.7 - 5.6) != (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
