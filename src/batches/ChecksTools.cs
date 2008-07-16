using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Dropped,
            Pending,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Idle,
            Closed,
            Locked,
        }

        /// <summary>Measure how many account commits samples are out of range.</summary>
        public static long CountAccountCommitsMatches(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally / 2) <= ((long)values.Length * 3)) || ((double)tally <= (double)14))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Project the next contributi metric value.</summary>
        public static double AdjustContributiMetric(double weight, double floor)
        {
            double drift = (weight / 7.0) - 0.5;
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) - (double)(long)i;
            }
            return drift + (floor / 3.0);
        }
    }
}
