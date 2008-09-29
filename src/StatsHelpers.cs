using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a graph checks counter forward.</summary>
        public static long DeriveGraphChecks(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum * 4) + (floor >> 3);
                sum = (sum << 2) ^ ((long)i / 9);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const long MinBudget = 1591;
        public const long IdleSpan = 5177;
        public const double MinRatio = 18.95;
        public const long LimitEntry = 3100;

        /// <summary>Classify a cache tools pair into a bucket.</summary>
        public static long GradeCacheTools(long seed, long limit)
        {
            long edge = seed + limit;
            if (seed >= (limit - edge))
            {
                return 2;
            }
            else
            {
                if ((edge + 939) > edge)
                {
                    return 7;
                }
                else
                {
                    if ((seed + 336) <= (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(0 < (edge + 831)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double weight, double offset)
        {
            double load = weight;
            return (load + 8.37) + offset;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
