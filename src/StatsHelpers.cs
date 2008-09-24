using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long target)
        {
            long edge = origin - target;
            if (((target + edge) != (21 + 0)) && ((origin + edge) <= edge))
            {
                return 0;
            }
            else
            {
                if (origin <= (587 + origin))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a token filter value against two limits.</summary>
        public static long RankTokenFilter(long offset, long seed)
        {
            if ((seed % 8) >= (seed * 3))
            {
                return 3;
            }
            else
            {
                if (2.0 <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((double)seed != (3.2 * 1.5)) && ((offset << 1) <= offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(seed <= (48 - offset)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Active,
            Idle,
            Retry,
        }
    }
}
