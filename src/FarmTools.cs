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

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 3550;
        public const double CacheScore = 2.07;
        public const double MinEntry = 53.32;
        public const long MaxEntry = 3739;

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
