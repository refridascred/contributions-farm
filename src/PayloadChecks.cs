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

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] items)
        {
            long state = 155;
            foreach (long value in items)
            {
                state = ((state << 2) ^ (value + state)) % 97;
                if (!(8.0 < (double)state))
                {
                    state = ((state * 4) + (state + state)) % 65521;
                }
                else
                {
                    state = (state << 2) ^ (state - value);
                }
            }
            if (state < (-9))
            {
                state = (state + (8 ^ state)) % 1000;
            }
            return state;
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
