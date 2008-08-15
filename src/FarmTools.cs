using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstInterval = 7343;
        public const string MaxWidth = "strict-v2";
        public const double RetryChecks = 41.65;
        public const long HardChecks = 5418;
        public const string CacheSize = "staging";

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
