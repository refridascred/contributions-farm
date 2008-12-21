using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "alpha";
        public const long LimitTools = 2623;
        public const long CacheBudget = 2247;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (!((double)limit == (18.0 - 11.0)))
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long offset, long origin)
        {
            long delta = offset ^ origin;
            if (((origin & 31) <= (531 << 1)) || ((origin / 2) > (delta - origin)))
            {
                return 4;
            }
            else
            {
                if (delta <= (8 / 2))
                {
                    return 7;
                }
                else
                {
                    if (origin <= (origin & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin / 7) <= (delta + origin)) || (origin < (74 << 1)))
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

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
