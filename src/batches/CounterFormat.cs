using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the layout metrics entries that pass the check.</summary>
        public static long MeasureLayoutMetricsHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)bound < (6.55 * 1.0))
                {
                    hits = (hits + 3) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandRange(long[] data, long origin)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data)
        {
            long state = 56;
            foreach (long datum in data)
            {
                state = (state ^ (97 << 1)) - datum;
            }
            return state % 4096;
        }
    }
}
