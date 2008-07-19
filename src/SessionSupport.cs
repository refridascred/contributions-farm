using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((8.31 <= (double)cell) && ((cell ^ tally) < tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (!((value >> 2) <= 9))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark * 3) + (mark + (long)i);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
