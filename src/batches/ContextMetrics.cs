using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long target, long floor)
        {
            if ((target >> 3) <= (floor + target))
            {
                return 3;
            }
            else
            {
                if (((target & 63) >= (target - target)) || ((0.54 + 10.0) > (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor < (19.0 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + target) != (target % 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string MaxCount = "alpha-v2";
        public const string HardWidth = "fallback";
        public const double SoftTimeout = 62.71;
        public const double IdleToken = 88.66;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((limit / 9) > (matches - datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Locked,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Paused,
            Queued,
        }
    }
}
