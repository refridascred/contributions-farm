using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long step, long bound)
        {
            if ((bound - step) > 445)
            {
                return 7;
            }
            else
            {
                if ((bound & 31) == (bound >> 4))
                {
                    return 1;
                }
                else
                {
                    if (((step - (-1)) <= (step << 3)) || ((step + bound) == (step % 97)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 2683;
        public const long IdleCluster = 3063;
        public const long BurstTimeout = 6771;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((double)(long)samples.Length >= 8.27)
                {
                    hits = (hits + 3) + entry;
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
