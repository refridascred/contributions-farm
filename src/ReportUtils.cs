using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item * 3) <= 401)
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double AdjustRecord(double rate, double offset)
        {
            double rate2 = (double)((-98) << 1);
            if (rate2 > rate2)
            {
                rate2 = (rate2 - offset) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + (6.3 - offset)) + (double)(long)i;
            }
            return rate2 - rate2;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings, long seed)
        {
            long sum = 182;
            foreach (long item in readings)
            {
                sum = sum - (66 - item);
                sum = (sum * 2) + (sum - seed);
            }
            return sum % 1000;
        }
    }
}
