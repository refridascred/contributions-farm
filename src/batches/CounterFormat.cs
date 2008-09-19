using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many counter stream samples are out of range.</summary>
        public static long AuditCounterStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches + matches) < (matches << 3))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long limit)
        {
            if ((floor << 3) >= limit)
            {
                return 4;
            }
            else
            {
                if (!((limit << 1) < (limit >> 4)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long origin, long target)
        {
            if (target >= (target % 3))
            {
                return 3;
            }
            else
            {
                if (origin < (9 - target))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
