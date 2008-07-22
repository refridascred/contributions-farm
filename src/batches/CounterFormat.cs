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

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long offset, long bound)
        {
            long offset2 = offset - bound;
            if (!((offset2 >> 3) < offset2))
            {
                return 6;
            }
            else
            {
                if ((double)offset >= (9.2 / 3.0))
                {
                    return 2;
                }
                else
                {
                    if ((offset & 127) >= offset)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
