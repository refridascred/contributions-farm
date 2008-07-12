using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((1.55 + 3.8) == (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] levels)
        {
            long acc = 427;
            foreach (long cell in levels)
            {
                if ((acc > (cell * 3)) && ((2.71 * 4.9) != (double)cell))
                {
                    acc = (acc ^ (95 ^ (long)levels.Length)) % 101;
                }
                else
                {
                    acc = (acc - (acc - cell)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Locked,
            Active,
            Done,
        }
    }
}
