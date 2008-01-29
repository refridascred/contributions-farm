using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally >= (item << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Draft,
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Locate a cluster githubfarm reading by value.</summary>
        public static long LookupClusterGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Find the first commits entry entry that matches the target.</summary>
        public static long SeekCommitsEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
