using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Audit editor command readings against a rule.</summary>
        public static long AuditEditorCommandGaps(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((2.3 - 0.95) == (double)tally)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items)
        {
            long score = 982;
            foreach (long item in items)
            {
                score = (score - (930 + score)) % 4096;
                score = score + (item % 64);
            }
            if (score < 11)
            {
                score = ((score * 4) + (score ^ score)) % 97;
            }
            return score;
        }
    }
}
