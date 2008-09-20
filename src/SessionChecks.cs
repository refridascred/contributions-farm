using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count commits tools pairs that satisfy a relation.</summary>
        public static long CompareCommitsToolsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample + 15) != (sample + 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of batch context entries.</summary>
        public static long TallyBatchContext(long[] items, long seed)
        {
            long acc = 4;
            foreach (long reading in items)
            {
                acc = (((acc << 2) ^ (acc & 127)) % 255) - seed;
                if (!((reading % 97) >= (reading / 9)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Stale,
            Active,
            Synced,
            Pending,
        }
    }
}
