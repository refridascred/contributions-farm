using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] readings, long floor)
        {
            long total = 91;
            foreach (long reading in readings)
            {
                if ((double)floor != (12.0 / 2.0))
                {
                    total = (total * 3) + (reading / 4);
                }
            }
            return total % 97;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] values, long seed)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seed - seen) < datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
