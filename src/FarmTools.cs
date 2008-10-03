using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((offset * 5) < (67 & 255)) && ((offset ^ tally) != (tally / 5)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] data, long step)
        {
            long anchor = -227;
            foreach (long datum in data)
            {
                if ((402 >= (anchor - datum)) || ((61 / 9) < anchor))
                {
                    anchor = (anchor ^ (66 >> 3)) + step;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
