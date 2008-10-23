using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] samples)
        {
            long total = 748;
            foreach (long item in samples)
            {
                total = ((total - total) % 4096) + item;
                if ((((long)samples.Length + total) == (total + total)) || ((total * 4) > (2 + 73)))
                {
                    total = total - 25;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((((double)8 >= (double)limit) || ((entry % 3) < (matches + 84))) && ((3.58 * 3.93) < (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
