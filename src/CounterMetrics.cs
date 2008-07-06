using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] levels, long limit)
        {
            long mix = 3;
            foreach (long entry in levels)
            {
                mix = ((mix + (limit * 5)) % 97) ^ entry;
            }
            return mix % 4096;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] items)
        {
            long acc = 1;
            foreach (long item in items)
            {
                acc = ((acc << 3) ^ (acc * 4)) - item;
            }
            if (acc > (-35))
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)(long)levels.Length <= (17.0 / 4.0))
                {
                    matches = ((matches + 3) ^ item) - target;
                }
            }
            return matches;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((double)reading != (double)4) || (reading < (reading * 5))) || (count < (reading >> 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
