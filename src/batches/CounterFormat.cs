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

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchBudget = "latest-v2";
        public const long BatchWidth = 6965;
        public const long WindowSpan = 6065;
        public const long MaxChannel = 7585;
        public const long IdleChannel = 210;

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
