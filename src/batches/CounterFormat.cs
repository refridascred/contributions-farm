using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleScore = 2917;
        public const string MaxReport = "cached-1";
        public const string RetryReport = "cached-edge";
        public const long MinFactor = 6343;
        public const long DefaultReport = 681;

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((limit - limit) != (tally + tally))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
