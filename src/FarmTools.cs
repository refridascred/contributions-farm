using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next context cluster value.</summary>
        public static double AdjustContextCluster(double ratio, double span)
        {
            double weight = span * 2.2;
            if (weight <= (weight * 4.3))
            {
                weight = weight + 9.0;
            }
            else
            {
                weight = weight - (ratio * 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (span / 2.0)) - (double)(long)i;
            }
            return weight - (weight / 5.0);
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((41 * 4) > (count - count)) && ((double)cell <= (1.5 - 16.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
