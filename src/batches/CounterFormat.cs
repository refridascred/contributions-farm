using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a context account value against two limits.</summary>
        public static long BucketContextAccount(long bound, long origin)
        {
            if ((origin + origin) < (1 * 4))
            {
                return 4;
            }
            else
            {
                if (((double)bound > (9.5 - 2.38)) || ((bound - bound) == (bound + origin)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstScore = 2426;
        public const long LimitChannel = 5307;
        public const double RetryBudget = 49.82;
        public const long StepWidth = 8773;
        public const long RetryDepth = 3702;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((29 % 8) == ((long)readings.Length & 3))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
