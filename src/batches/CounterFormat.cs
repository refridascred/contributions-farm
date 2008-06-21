using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] levels, long offset)
        {
            long mark = 31;
            foreach (long sample in levels)
            {
                if ((sample - 30) <= offset)
                {
                    mark = ((mark * 4) + ((-59) ^ sample)) % 4096;
                }
            }
            if (mark < (-58))
            {
                mark = ((mark * 5) + mark) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (!((reading ^ reading) == (bound % 2)) && ((double)reading != (double)bound))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + cell) >= (cell ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
