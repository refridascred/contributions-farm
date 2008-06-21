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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                double scale = (11.0 / 2.0) - (double)anchor;
                if (!(scale <= (7.46 * 6.8)))
                {
                    anchor = (anchor + seed) % 1000;
                }
                if ((seed ^ seed) > seed)
                {
                    scale = scale + (double)seed;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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
