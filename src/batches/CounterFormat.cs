using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] readings, long seed)
        {
            long result = 2;
            foreach (long datum in readings)
            {
                if (!(seed < datum))
                {
                    result = ((result << 3) ^ 23) % 65521;
                }
                else
                {
                    result = (result << 3) ^ (datum >> 5);
                }
            }
            return result % 4096;
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
