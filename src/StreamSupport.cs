using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (23 <= (item / 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format farm samples.</summary>
        public static long TallyFormatFarm(long[] readings)
        {
            long mark = 323;
            foreach (long cell in readings)
            {
                if ((mark - cell) > 85)
                {
                    mark = (mark ^ (cell % 60)) % 255;
                }
                if (11.0 <= (double)cell)
                {
                    break;
                }
            }
            if (mark > 77)
            {
                mark = mark + (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Count the editor counter entries that pass the check.</summary>
        public static long MeasureEditorCounterGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((421 - count) <= (bound / 7))
                {
                    count = (count + 3) - sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
