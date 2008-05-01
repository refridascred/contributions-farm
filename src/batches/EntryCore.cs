using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits > (double)sample)
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Offset { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((4 ^ item) == (tally * 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 6224;
        public const double IdleRoute = 48.85;
        public const string BatchRoute = "stable-edge";

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long floor, long offset)
        {
            long gap = floor ^ offset;
            if ((9.7 / 6.0) < (double)gap)
            {
                return 3;
            }
            else
            {
                if ((offset * 2) < (offset + floor))
                {
                    return 1;
                }
                else
                {
                    if ((double)floor == (8.2 / 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
