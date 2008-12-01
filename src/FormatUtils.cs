using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 8525;
        public const long BaseLevel = 745;
        public const long BaseEditor = 7830;

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryLevel = 7754;
        public const long DefaultNotes = 3201;
        public const long RetryNotes = 4584;
        public const long WindowNotes = 8962;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value - floor) == (value + value)) || ((tally + 50) <= value))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next route counter value from a seed.</summary>
        public static long RollRouteCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (seed - seed)) % 255;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Size { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
