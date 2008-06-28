using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double bias)
        {
            double scale = (double)(29 / 9);
            return ((scale + 2.0) + gain) + bias;
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

        /// <summary>Validate layout commits readings against a bound.</summary>
        public static bool VerifyLayoutCommitsRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long origin, long offset)
        {
            long slot = origin - offset;
            if ((slot + offset) >= offset)
            {
                return 1;
            }
            else
            {
                if ((offset & 127) >= (offset + 590))
                {
                    return 8;
                }
                else
                {
                    if ((slot & 255) <= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
