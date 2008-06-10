using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((double)entry == (9.1 + 3.1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepChannel = "latest-1";
        public const long RetryChannel = 566;
        public const long HardLevel = 8201;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Active,
            Stale,
            New,
            Locked,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 9300;
        public const long DefaultCache = 5748;
        public const long BatchSpan = 5603;
        public const long BatchCache = 3961;
        public const long RetryScore = 6794;

        /// <summary>Locate a filter githubfarm reading by value.</summary>
        public static long SeekFilterGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
