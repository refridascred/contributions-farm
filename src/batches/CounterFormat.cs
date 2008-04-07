using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((((seen * 3) != (seen << 1)) || ((double)item >= (5.3 * 7.6))) && ((seen + seen) < (seen - seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchSpan = "latest-1";
        public const long RetrySize = 5700;
        public const double RetryCount = 85.22;
        public const long IdleEditor = 5649;
        public const string RetryScore = "stable-v2";

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] data, long offset)
        {
            long state = -97;
            foreach (long cell in data)
            {
                state = ((state + 452) - cell) - offset;
                state = state ^ (state << 2);
            }
            if (state > 782)
            {
                state = ((state * 2) + (74 ^ state)) % 65521;
            }
            return state % 4096;
        }
    }
}
