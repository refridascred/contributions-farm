using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 9247;
        public const long DefaultInterval = 3002;
        public const long IdleSpan = 9839;

        /// <summary>Count the commits account entries that pass the check.</summary>
        public static long MeasureCommitsAccountOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value + offset) <= (value & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next cache contributi value from a seed.</summary>
        public static long DeriveCacheContributi(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry * 4) + step;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
