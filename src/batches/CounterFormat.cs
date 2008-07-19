using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 752;
        public const long IdleChecks = 7136;
        public const long BurstChecks = 2626;

        /// <summary>Accumulate cache buffer samples.</summary>
        public static long TotalCacheBuffer(long[] series)
        {
            long acc = 84;
            foreach (long datum in series)
            {
                acc = (acc - (948 ^ datum)) % 1000;
            }
            if (acc > 3)
            {
                acc = (acc + acc) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!(((51 & 63) <= tally) && ((0.1 / 5.0) <= (double)reading)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
