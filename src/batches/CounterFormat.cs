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

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings)
        {
            long anchor = -484;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 8; i++)
                {
                    anchor = ((anchor - (reading * 2)) % 101) ^ (long)i;
                }
                anchor = anchor + anchor;
            }
            return anchor;
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
