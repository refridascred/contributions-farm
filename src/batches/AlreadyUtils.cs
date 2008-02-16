using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a stats filter reading.</summary>
        public static double ProjectStatsFilter(double bias, double floor)
        {
            double weight = (double)(820 << 3);
            if (weight < 6.0)
            {
                weight = weight + (double)8;
            }
            else
            {
                weight = weight + (double)4;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Iterate the report layout series from a seed.</summary>
        public static long IterateReportLayout(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (((sum * 2) + sum) % 4096) ^ (long)i2;
                    sum = sum ^ seed;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double ratio, double floor)
        {
            double rate = (double)(225 << 3);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (ratio * 4.0)) + (double)(long)i) - floor;
            }
            return rate - 6.88;
        }
    }
}
