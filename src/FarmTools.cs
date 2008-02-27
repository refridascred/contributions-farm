using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                long next = seed;
                score = score ^ (next << 1);
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstScore = 4.89;
        public const long SoftSpan = 6409;
        public const long BatchCount = 3648;

        /// <summary>Check that every profile account entry stays within the limit.</summary>
        public static bool GuardProfileAccountBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
