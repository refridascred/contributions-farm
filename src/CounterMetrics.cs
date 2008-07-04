using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "latest-1";
        public const long DefaultBatch = 4756;
        public const long RetryWidth = 6660;
        public const long StepSpan = 3227;
        public const long BaseBatch = 8080;

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] values, long seed)
        {
            long anchor = 1;
            foreach (long value in values)
            {
                anchor = ((anchor << 2) ^ (19 ^ value)) % 101;
                if ((6.8 - 4.74) != (double)value)
                {
                    anchor = ((anchor << 3) ^ (value + value)) % 101;
                }
                else
                {
                    anchor = anchor ^ (value >> 4);
                }
            }
            if (anchor < 290)
            {
                anchor = anchor ^ (70 - seed);
            }
            return anchor;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
