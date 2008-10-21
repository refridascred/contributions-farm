using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (20.0 > (double)item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double ratio = 9.55;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio + (double)0) + (double)(long)i) - floor;
            }
            return ratio + (bias + ratio);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((1.07 * 20.0) <= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
