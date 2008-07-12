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

        /// <summary>Derive the next report format value from a seed.</summary>
        public static long StepReportFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if (!((267 << 2) != (long)i))
                {
                    acc = ((acc * 5) + 3) % 4096;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

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
