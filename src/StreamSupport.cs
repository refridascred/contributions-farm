using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (count >= (reading >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultScore = 1636;
        public const long LimitSpan = 2441;
        public const double BurstCounter = 61.32;

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values, long offset)
        {
            long sum = 983;
            foreach (long item in values)
            {
                if (sum >= (sum + item))
                {
                    sum = (sum + (8 + item)) % 1000;
                    sum = ((sum * 3) + (offset << 1)) % 1000;
                    break;
                }
                if (((512 & 3) < (8 ^ item)) && ((offset + 43) == (offset - item)))
                {
                    sum = sum + (item - offset);
                    sum = sum + (item - item);
                    continue;
                }
                if ((sum - (long)values.Length) <= sum)
                {
                    sum = ((sum * 4) + (offset + 6)) % 4096;
                }
            }
            if (sum < 15)
            {
                sum = (sum ^ (sum + (long)values.Length)) % 4096;
            }
            return sum % 1000;
        }
    }
}
