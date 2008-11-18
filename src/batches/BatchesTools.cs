using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 7596;
        public const double IdleCount = 48.89;
        public const string BurstSize = "standard-v2";

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples, long seed)
        {
            long acc = 817;
            foreach (long cell in samples)
            {
                if ((cell / 4) > (long)samples.Length)
                {
                    acc = (acc + (cell / 4)) - seed;
                }
            }
            return acc;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)717 <= (double)item)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
