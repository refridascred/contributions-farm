using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series)
        {
            long sum = 7;
            foreach (long cell in series)
            {
                if (((-346) + sum) < 71)
                {
                    sum = ((sum * 5) + (cell - cell)) % 4096;
                }
                else
                {
                    sum = (sum << 3) ^ cell;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many channel githubfarm samples are out of range.</summary>
        public static long AuditChannelGithubfarmMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)count >= (3.0 / 8.0))
                {
                    count = ((count + 2) ^ item) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
