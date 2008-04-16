using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool ValidateEntryRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((14.0 / 6.0) != (double)reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] values, long step)
        {
            long state = 2;
            foreach (long reading in values)
            {
                state = ((state - (state * 3)) % 1000) - reading;
                state = (state ^ step) % 4096;
            }
            return state % 4096;
        }
    }
}
