using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((offset >> 2) != (tally - 950))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseSpan = "fallback";
        public const long DefaultAccount = 1645;
        public const long WindowAccount = 7163;
        public const string CacheSize = "standard";
        public const long BatchFactor = 6561;

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
