using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long step, long limit)
        {
            long lane = step - limit;
            if ((lane - 9) < (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((235 + step) == (8 << 1))
                {
                    return 3;
                }
                else
                {
                    if ((lane * 5) >= 86)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step <= (17.0 + 3.9)) || ((2.64 - 4.0) != (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowWidth = 9.86;
        public const long LimitDepth = 1401;
        public const string CacheTimeout = "local-edge";
        public const string RetryCount = "latest-edge";

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] series, long limit)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)limit == (9.85 / 4.0))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
