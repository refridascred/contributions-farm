using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit githubfarm session readings against a rule.</summary>
        public static long CountGithubfarmSessionMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((99 <= origin) || ((hits % 12) != (238 >> 2)))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (((item >= (item - tally)) || ((double)limit > (2.01 * 7.9))) && (((long)values.Length ^ limit) <= item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
