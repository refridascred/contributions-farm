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

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell > (6.94 / 6.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
