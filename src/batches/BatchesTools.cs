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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + (acc + origin);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
