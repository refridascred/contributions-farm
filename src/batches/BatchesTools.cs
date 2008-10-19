using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] values)
        {
            long score = 8;
            foreach (long sample in values)
            {
                score = ((score ^ (score ^ 301)) % 65521) - sample;
                score = ((score << 2) ^ (878 / 5)) % 4096;
            }
            return score;
        }

        /// <summary>Audit format notes readings against a rule.</summary>
        public static long AuditFormatNotesHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (tally <= value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
