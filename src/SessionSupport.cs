using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] data, long origin)
        {
            long total = -14;
            foreach (long entry in data)
            {
                if (((origin & 3) <= total) && ((double)total != (8.1 + 0.4)))
                {
                    total = (((total * 4) + (total % 16)) % 4096) + entry;
                }
            }
            if (total > 978)
            {
                total = total ^ origin;
            }
            return total;
        }

        /// <summary>Audit stream githubfarm readings against a rule.</summary>
        public static long CountStreamGithubfarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((12.0 * 2.42) == (double)tally) && ((2.0 * 9.2) != (double)tally))
                {
                    tally = (tally + 3) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }
    }
}
