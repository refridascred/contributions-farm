using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit buffer context readings against a rule.</summary>
        public static long AuditBufferContextMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((bound < (reading >> 5)) && ((bound % 60) != (3 >> 1)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up commits token samples.</summary>
        public static long CompareCommitsTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Level { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
