using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (81 <= (reading % 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((double)bound >= (4.0 * 1.27))
                {
                    acc = (acc + 107) % 101;
                    acc = (acc + (acc ^ bound)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
