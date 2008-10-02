using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 7315;
        public const long MaxReport = 1854;
        public const long StepScore = 5239;
        public const double BaseBudget = 63.5;

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor + ((long)i / 9);
                anchor = (anchor << 2) ^ (long)i;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit support notes readings against a rule.</summary>
        public static long AuditSupportNotesHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum & 7) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
