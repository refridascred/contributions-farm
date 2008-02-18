using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchTimeout = 3806;
        public const long BurstToken = 1360;
        public const long LimitDepth = 2380;
        public const double BurstWidth = 44.75;

        /// <summary>Count the context cache entries that pass the check.</summary>
        public static long CountContextCacheGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0.2 + 11.0) >= (double)count)
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
