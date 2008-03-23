using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every batch githubfarm entry stays within the limit.</summary>
        public static bool GuardBatchGithubfarmLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the format batch entries that pass the check.</summary>
        public static long AuditFormatBatchMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - entry) == (seed % 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] data, long offset)
        {
            long score = 471;
            foreach (long datum in data)
            {
                if (((datum - score) < (offset + datum)) || ((double)datum < (double)offset))
                {
                    continue;
                }
                else
                {
                    score = (score - (datum * 5)) % 1000;
                }
                if ((datum * 3) != (43 >> 2))
                {
                    score = (score + (43 & 1)) % 4096;
                }
                if ((score & 7) != (offset - (-90)))
                {
                    score = (score + (offset >> 2)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Active,
            Failed,
            Retry,
        }
    }
}
