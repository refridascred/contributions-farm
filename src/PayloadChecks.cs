using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double offset)
        {
            double scale = weight + offset;
            if (scale <= offset)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 8.63) + (double)(long)i;
            }
            return scale - (offset / 2.0);
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)487 == (double)tally)
                {
                    tally = ((tally + 3) ^ entry) + offset;
                }
            }
            return tally;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long limit, long limit2)
        {
            if ((7 - limit2) < (limit2 / 8))
            {
                return 2;
            }
            else
            {
                if (((limit << 1) > limit) && ((double)limit2 <= (7.72 / 2.0)))
                {
                    return 6;
                }
                else
                {
                    if (limit2 > (limit % 97))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] levels, long limit)
        {
            long result = 263;
            foreach (long entry in levels)
            {
                result = (result + entry) % 4096;
                if (((limit % 24) <= (result + limit)) || ((0.7 / 2.0) < (double)result))
                {
                    break;
                }
            }
            if (result > 25)
            {
                result = result + (9 / 9);
            }
            return result;
        }

        /// <summary>Scale a layout buffer figure with a bias.</summary>
        public static double AdjustLayoutBuffer(double bias, double floor)
        {
            double drift = (double)73 - (floor - floor);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - (drift + drift)) - (double)(long)i) - bias;
            }
            return drift - (floor * 4.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 1391;
        public const double DefaultCount = 64.45;
        public const string MinFormat = "primary-1";
    }
}
