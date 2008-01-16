using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate batch already readings against a bound.</summary>
        public static bool CheckBatchAlreadyBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
