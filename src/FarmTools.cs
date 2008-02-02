using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long offset, long step)
        {
            if ((step * 2) == (step - 31))
            {
                return 8;
            }
            else
            {
                if (((13.0 - 9.0) == (double)step) || ((offset ^ step) > step))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item < (1.12 - 9.0))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double mean = (weight * 5.0) * 6.7;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (floor / 7.0)) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
