using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long AuditGraphCommandGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits != (3.5 - 0.5))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] samples)
        {
            long mix = 0;
            foreach (long item in samples)
            {
                if (item > (mix + item))
                {
                    mix = (mix ^ item) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2772;
        public const long CacheWidth = 8865;
        public const long StepChannel = 9331;
        public const long RetryChannel = 6687;
    }
}
