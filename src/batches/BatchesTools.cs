using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 6407;
        public const long MinGraph = 7970;
        public const long WindowGraph = 3479;
        public const long BaseGraph = 3271;
        public const long IdleGraph = 7979;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample - sample) > 636)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally >= (entry + entry)) && ((double)422 > (double)entry))
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }
    }
}
