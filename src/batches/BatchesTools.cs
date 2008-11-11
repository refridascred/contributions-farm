using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultTimeout = 4883;
        public const long MinScore = 3559;
        public const long CacheMetric = 3927;
        public const double HardMetric = 89.69;
        public const long SoftWidth = 3506;

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples)
        {
            long result = 1;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ 780) % 101;
                if ((result - cell) != (result + cell))
                {
                    break;
                }
                if ((result ^ result) < cell)
                {
                    result = ((result * 5) + (cell + cell)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell >= (cell & 3))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
