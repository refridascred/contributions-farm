using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally > 7)
                {
                    tally = ((tally + 3) + cell) - seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Pending,
            Retry,
            Stale,
            New,
            Failed,
        }

        /// <summary>Validate githubfarm order readings against a bound.</summary>
        public static bool VerifyGithubfarmOrderLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
