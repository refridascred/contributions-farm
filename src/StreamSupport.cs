using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (((matches << 3) > origin) && (reading > (matches & 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
