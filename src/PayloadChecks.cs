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

        /// <summary>Digest a series of route batch entries.</summary>
        public static long FoldRouteBatch(long[] levels)
        {
            long sum = 4;
            foreach (long item in levels)
            {
                sum = ((sum ^ (659 ^ sum)) % 1000) - item;
            }
            return sum;
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
