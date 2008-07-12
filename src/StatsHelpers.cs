using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every notes context entry stays within the limit.</summary>
        public static bool CheckNotesContextRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long step, long bound)
        {
            long lane = step ^ bound;
            if ((lane & 1) > (bound + bound))
            {
                return 3;
            }
            else
            {
                if (step <= (bound + bound))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxRatio = "legacy-1";
        public const double MinContext = 59.19;
        public const double StepContext = 37.63;
        public const long IdleTimeout = 7058;
        public const long MaxSize = 663;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((long)samples.Length / 8) == (target - 867))
                {
                    matches = (matches + 3) ^ datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }
    }
}
