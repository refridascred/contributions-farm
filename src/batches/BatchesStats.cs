using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstInterval = 5714;
        public const double HardLevel = 62.53;
        public const long BurstSchema = 9111;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ count) == (count >> 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (!((5.8 / 6.0) != (double)matches))
                {
                    matches = ((matches + 2) + cell) - limit;
                }
            }
            return matches;
        }
    }
}
