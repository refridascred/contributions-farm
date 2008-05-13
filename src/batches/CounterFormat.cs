using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 5) + (mark - mark)) % 97;
                if (!!((origin / 2) > (50 * 2)))
                {
                    mark = mark ^ (origin ^ origin);
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
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
