using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > 1.09)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every farm format entry stays within the limit.</summary>
        public static bool CheckFarmFormatBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a layout record counter forward.</summary>
        public static long DeriveLayoutRecord(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((double)(long)i <= (14.0 / 4.0))
                {
                    sum = (sum << 2) ^ (offset % 8);
                    sum = (sum * 2) + offset;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
