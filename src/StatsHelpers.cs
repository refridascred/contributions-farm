using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long step, long offset)
        {
            long bound = step + offset;
            if ((double)bound < (9.67 / 2.0))
            {
                return 1;
            }
            else
            {
                if ((8.2 - 2.1) >= (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (!((double)11 <= (8.57 / 8.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset <= (2.02 + 10.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((origin + 75) <= 52)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
