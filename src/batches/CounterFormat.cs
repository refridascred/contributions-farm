using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string HardTimeout = "alpha-1";
        public const long MaxBudget = 2037;
        public const string MinCount = "strict";
        public const long LimitWindow = 4152;

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long origin, long seed)
        {
            long slot = origin ^ seed;
            if ((slot + origin) < (slot + slot))
            {
                return 6;
            }
            else
            {
                if ((origin & 3) != (slot - seed))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
