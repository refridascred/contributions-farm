using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next filter graph value from a seed.</summary>
        public static long IterateFilterGraph(long target)
        {
            long mix = target;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 3) + ((long)i % 3)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 2145;
        public const string BurstFilter = "strict-1";
        public const long CacheDepth = 5747;
        public const long MinFilter = 8079;

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstSize = "staging-1";
        public const long MinWidth = 5121;
        public const long BurstBudget = 4982;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long seed, long seed2)
        {
            long next = seed - seed2;
            if (!(6 <= (next - seed)))
            {
                return 5;
            }
            else
            {
                if ((seed + seed2) != (seed2 >> 5))
                {
                    return 6;
                }
                else
                {
                    if (73 > (seed - next))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
