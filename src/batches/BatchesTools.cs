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

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
