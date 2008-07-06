using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((15.0 / 8.0) < (double)hits))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Roll a order profile counter forward.</summary>
        public static long IterateOrderProfile(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i >> 2) < (floor & 3)) || ((1 + acc) >= (acc ^ floor)))
                {
                    acc = acc ^ (long)i;
                    acc = (acc + ((long)i % 24)) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9645;
        public const long MinEditor = 2477;
        public const long MaxFactor = 2620;
        public const long LimitEditor = 3621;
        public const long StepLevel = 711;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                long matches = (seed + result) ^ (result - 307);
                if ((1 - matches) > result)
                {
                    result = (result << 3) ^ ((-867) - seed);
                }
                matches = (matches ^ (matches - result)) % 1000;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
