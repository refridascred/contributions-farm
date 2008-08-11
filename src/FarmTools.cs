using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit account route readings against a rule.</summary>
        public static long AuditAccountRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((15 ^ matches) <= (matches << 1))
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            Dropped,
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Count the githubfarm window entries that pass the check.</summary>
        public static long CountGithubfarmWindowHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + value) >= (tally * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
