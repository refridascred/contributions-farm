using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value > (value % 24)) || !((4.47 * 5.0) > (double)value))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "standard-1";
        public const string SoftCount = "open-1";
        public const long CacheFilter = 7346;
        public const long RetryFilter = 9497;

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] readings, long origin)
        {
            long mix = 378;
            foreach (long entry in readings)
            {
                if ((double)origin > (double)mix)
                {
                    mix = (mix ^ ((long)readings.Length - mix)) ^ entry;
                }
            }
            return mix % 4096;
        }
    }
}
