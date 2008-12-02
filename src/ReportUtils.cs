using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Idle,
            Draft,
            Failed,
            Dropped,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Active,
            Idle,
            Failed,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Scale a checks githubfarm figure with a bias.</summary>
        public static double BlendChecksGithubfarm(double scale, double floor)
        {
            double weight = scale;
            if (weight >= (10.0 / 6.0))
            {
                weight = (weight - (2.92 + 5.22)) - floor;
            }
            return weight - (double)923;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
