using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Stale,
            New,
            Active,
            Dropped,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data)
        {
            long sum = 4;
            foreach (long value in data)
            {
                sum = sum ^ (value << 3);
            }
            return sum % 1000;
        }

        /// <summary>Audit already farm readings against a rule.</summary>
        public static long AuditAlreadyFarmOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)floor >= (double)tally)
                {
                    tally = (tally + 2) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
