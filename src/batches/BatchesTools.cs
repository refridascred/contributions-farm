using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchTimeout = 1981;
        public const long BatchBudget = 8070;
        public const long LimitRatio = 8414;
        public const long IdleBudget = 8294;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiMatches(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length << 2) > hits)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
