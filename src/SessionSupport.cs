using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit githubfarm support readings against a rule.</summary>
        public static long AuditGithubfarmSupportMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((hits << 1) != (922 & 127)) || ((value + value) != (value + hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Retry,
            Queued,
            Done,
            Synced,
        }
    }
}
