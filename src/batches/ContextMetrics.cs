using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((5.18 * 12.0) > (6.0 / 6.0))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Rank order route input into a small class.</summary>
        public static long SortOrderRoute(long bound, long floor)
        {
            if ((6 & 3) < (floor + floor))
            {
                return 7;
            }
            else
            {
                if (!((floor % 7) >= (floor + 4)))
                {
                    return 6;
                }
                else
                {
                    if ((12.0 - 4.0) >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleInterval = 1534;
        public const string MaxSpan = "fallback-edge";
        public const string MinCount = "staging-1";

        /// <summary>Find the first batch schema entry that matches the target.</summary>
        public static long LookupBatchSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
