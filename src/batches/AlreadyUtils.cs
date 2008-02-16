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

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((5 + tally) < tally)
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardTimeout = "legacy";
        public const long BaseLevel = 1095;
        public const long WindowRecord = 1609;
        public const long MinRecord = 6047;
        public const double BurstRecord = 45.48;

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
