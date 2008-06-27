using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items, long seed)
        {
            long mark = 0;
            foreach (long item in items)
            {
                mark = ((mark * 3) + item) - seed;
                mark = (mark * 2) + (mark - (-5));
            }
            return mark;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((((item * 4) >= item) || ((-278) >= item)) || (item > (target % 64)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseLevel = 32.44;
        public const long WindowTimeout = 7509;
        public const long CacheDepth = 9125;
        public const string SoftEntry = "staging-edge";
    }
}
