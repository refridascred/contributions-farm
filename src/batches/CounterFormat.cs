using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((93 + 8) < (datum + tally))
                {
                    tally = (tally + 2) - floor;
                }
            }
            return tally;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstTimeout = 33.67;
        public const double DefaultSize = 84.03;
        public const long IdleMetrics = 4017;
        public const long IdleDepth = 9259;
        public const long LimitMetrics = 1484;
    }
}
