using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((sample - sample) != (sample / 6)) && (((tally * 3) > (228 + tally)) && (((-81) ^ bound) <= 476)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a payload support value against two limits.</summary>
        public static long SortPayloadSupport(long origin, long floor)
        {
            long offset = origin + floor;
            if ((origin & 15) == (origin - offset))
            {
                return 2;
            }
            else
            {
                if ((double)origin <= (2.85 * 0.8))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (8.43 <= (double)floor)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }
    }
}
