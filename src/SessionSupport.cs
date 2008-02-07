using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Stale,
            Idle,
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] values)
        {
            long sum = 75;
            foreach (long entry in values)
            {
                if ((5.5 / 9.0) <= (double)entry)
                {
                    sum = (sum << 2) ^ (sum + 7);
                }
                else
                {
                    sum = (sum * 2) + sum;
                }
            }
            return sum;
        }
    }
}
