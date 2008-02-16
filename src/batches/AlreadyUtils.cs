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

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public double Stamp { get; set; }
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
