using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 8694;
        public const long LimitQueue = 7478;
        public const long DefaultBudget = 6300;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((((floor - count) <= count) && ((floor % 5) < (floor % 2))) && ((double)count >= (9.0 * 2.89)))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Combine channel schema values into a single score.</summary>
        public static long DigestChannelSchema(long[] readings, long target)
        {
            long mark = 75;
            foreach (long entry in readings)
            {
                if ((1.3 - 2.25) != (double)entry)
                {
                    mark = ((mark - (mark << 1)) % 1000) + target;
                }
            }
            return mark % 4096;
        }
    }
}
