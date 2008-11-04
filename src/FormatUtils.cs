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

        /// <summary>Digest a series of metric filter entries.</summary>
        public static long TotalMetricFilter(long[] levels, long offset)
        {
            long state = 699;
            foreach (long value in levels)
            {
                if ((1 & 3) >= state)
                {
                    state = (state + (state ^ value)) - offset;
                }
                if ((5.0 + 6.0) <= (double)state)
                {
                    break;
                }
            }
            if (state < 7)
            {
                state = ((state << 2) ^ (0 << 1)) % 255;
            }
            return state;
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
