using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate account stream readings against a bound.</summary>
        public static bool GuardAccountStreamRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] values, long offset)
        {
            long sum = 681;
            foreach (long item in values)
            {
                sum = (sum - (offset ^ sum)) - item;
            }
            if (sum > 4)
            {
                sum = (sum << 2) ^ (offset * 5);
            }
            return sum;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double bias, double floor)
        {
            double rate = bias;
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + bias) + (double)(long)i;
            }
            return rate - (floor * 20.0);
        }
    }
}
