using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchSpan = 3194;
        public const long CacheCounter = 2129;
        public const long IdleCount = 8413;

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] items, long limit)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                if (((double)sum > (double)limit) && ((5 - sum) >= sum))
                {
                    break;
                }
                if ((datum % 7) < (88 * 3))
                {
                    sum = ((sum << 2) ^ datum) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((2.0 * 19.0) != (double)value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
