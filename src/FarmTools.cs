using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the checks notes entries that pass the check.</summary>
        public static long CountChecksNotesMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((4.4 + 2.29) < (double)count)
                {
                    count = (count + 3) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value % 10) < matches)
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double rate, double bias)
        {
            double ratio = (1.0 - rate) + (bias + rate);
            if (ratio >= rate)
            {
                ratio = ratio - (double)510;
            }
            else
            {
                ratio = ratio - 5.5;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (rate / 9.0)) - (double)(long)i;
            }
            return ratio - (bias + bias);
        }
    }
}
