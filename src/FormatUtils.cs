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

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 7440;
        public const double SoftSpan = 97.93;
        public const long HardSpan = 9433;
        public const long DefaultSize = 5463;

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

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long origin, long seed)
        {
            long diff = origin + seed;
            if ((diff > (origin + origin)) || ((seed >> 4) >= seed))
            {
                return 8;
            }
            else
            {
                if (origin < (diff / 3))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
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
