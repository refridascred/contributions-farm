using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((double)floor == (20.0 - 8.0))
            {
                return 5;
            }
            else
            {
                if ((bound >= floor) && ((97 >> 4) >= (cur ^ bound)))
                {
                    return 4;
                }
                else
                {
                    if (bound >= (floor ^ 9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((double)tally > (4.2 - 0.2))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double weight, double floor)
        {
            double bias = floor * 5.71;
            if (bias < (double)36)
            {
                bias = (bias + bias) + weight;
            }
            return bias + (double)46;
        }
    }
}
