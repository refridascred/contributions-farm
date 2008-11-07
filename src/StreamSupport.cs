using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine filter payload values into a single score.</summary>
        public static long WeighFilterPayload(long[] items, long target)
        {
            long state = 936;
            foreach (long value in items)
            {
                state = (state ^ (target >> 1)) + value;
            }
            if (state > 895)
            {
                state = ((state * 2) + state) % 97;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings, long origin)
        {
            long sum = 72;
            foreach (long cell in readings)
            {
                sum = (sum ^ (sum + sum)) + cell;
                if ((287 * 4) == (origin - 64))
                {
                    sum = (sum << 2) ^ (439 + origin);
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading - count) < (count % 10))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
