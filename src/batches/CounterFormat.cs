using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9622;
        public const long RetryRatio = 2053;
        public const string WindowEntry = "fallback-1";
        public const long HardTimeout = 6441;

        /// <summary>Grade a session queue value against two limits.</summary>
        public static long ClassifySessionQueue(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((offset >= (bound ^ offset)) && ((1.38 * 6.8) >= (double)gap))
            {
                return 0;
            }
            else
            {
                if ((offset + bound) >= (1 / 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset < (7.5 / 5.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length < (2.12 * 1.4))
                {
                    seen = ((seen + 3) + entry) + seed;
                }
            }
            return seen;
        }
    }
}
