using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardFactor = 9451;
        public const long RetryNotes = 3601;
        public const long DefaultNotes = 8074;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum > (tally * 5))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((9.9 / 5.0) != (double)offset)
                {
                    count = (count + 3) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
