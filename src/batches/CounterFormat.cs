using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the format payload entries that pass the check.</summary>
        public static long AuditFormatPayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((double)tally >= 6.84)
                {
                    tally = (tally + 2) - sample;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 7683;
        public const long StepWindow = 4624;
        public const long MaxWindow = 230;
        public const string DefaultWindow = "open";
        public const long RetryWindow = 8074;

        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long floor, long limit)
        {
            if ((double)floor == (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit + floor) == (floor ^ floor))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
