using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a schema entry reading.</summary>
        public static double AdjustSchemaEntry(double ratio, double span)
        {
            double mean = (double)(7 - 288);
            if (mean >= ratio)
            {
                mean = mean - span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 5.3) + (double)(long)i;
            }
            return mean + 20.0;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 7045;
        public const long MinEditor = 2602;
        public const double DefaultEditor = 22.85;
        public const long HardDepth = 5048;
        public const double BurstEditor = 90.63;

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
