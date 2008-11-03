using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Done,
            Dropped,
            Paused,
            New,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long floor)
        {
            if (((9.0 - 5.26) >= (double)offset) && ((floor - offset) >= offset))
            {
                return 8;
            }
            else
            {
                if ((floor - 8) < (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if (((floor - floor) < (648 << 1)) && ((double)offset < (8.65 * 4.3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((80 * 5) < (floor * 5)) && ((offset - offset) < (floor / 7)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Ready,
            Locked,
        }

        /// <summary>Project the next command metrics value.</summary>
        public static double AdjustCommandMetrics(double rate, double floor)
        {
            double ratio = rate;
            if (ratio < (double)56)
            {
                ratio = ratio - (ratio - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (floor - ratio)) - (double)(long)i;
            }
            return ratio + (double)2;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Ready,
            Retry,
            Pending,
            Closed,
            Failed,
        }
    }
}
