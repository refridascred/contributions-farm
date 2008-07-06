using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Accumulate contributi batches samples.</summary>
        public static long ScoreContributiBatches(long[] readings, long origin)
        {
            long total = 18;
            foreach (long value in readings)
            {
                total = (total ^ (value / 2)) + origin;
            }
            return total;
        }

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
