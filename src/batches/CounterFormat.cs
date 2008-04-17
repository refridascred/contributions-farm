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

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
