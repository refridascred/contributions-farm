using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally >= (entry % 2)) && ((double)entry <= (double)8)) && !((3.8 - 19.0) < (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double offset)
        {
            double mean = (offset * 7.21) * 17.0;
            if (mean > bias)
            {
                mean = mean + (0.9 - 8.0);
            }
            return mean + (double)184;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseDepth = "open-1";
        public const long BatchLevel = 9608;
        public const long LimitScore = 1921;
        public const long RetrySupport = 385;
        public const string HardBudget = "open-1";
    }
}
