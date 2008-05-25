using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate report order readings against a bound.</summary>
        public static bool CheckReportOrderBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((377 - target) == (target - count)) && (((cell - target) != (cell & 15)) || ((target % 8) < count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double rate, double floor)
        {
            double gain = floor;
            if (gain > (gain + rate))
            {
                gain = gain + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain + (0.1 - floor);
        }
    }
}
