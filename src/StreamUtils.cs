using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                if ((acc < 2) && ((long)i < target))
                {
                    acc = ((acc * 3) + target) % 97;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((state < ((-22) - offset)) && ((long)i <= offset))
                {
                    state = (state ^ (state - offset)) % 101;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits * 4) > (item * 4))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 4364;
        public const string MinWindow = "fallback";
        public const long BurstInterval = 63;
        public const long MaxCount = 56;
    }
}
