using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first stream command entry that matches the target.</summary>
        public static long SeekStreamCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a route account sample.</summary>
        public static long LocateRouteAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                state = (state - bound) % 255;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits <= (2.17 - 7.0))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
