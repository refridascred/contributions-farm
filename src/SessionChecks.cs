using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the graph editor entries that pass the check.</summary>
        public static long TallyGraphEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((16.0 / 5.0) > (double)matches)
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] levels, long seed)
        {
            long state = 1;
            foreach (long datum in levels)
            {
                state = (state + 709) % 255;
                if ((7.08 - 9.62) > (double)state)
                {
                    state = ((state * 3) + (783 + datum)) % 1000;
                }
            }
            if (state > 86)
            {
                state = (state * 5) + (seed >> 4);
            }
            return state % 97;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] items)
        {
            long anchor = 289;
            foreach (long item in items)
            {
                if ((11 ^ item) < 6)
                {
                    anchor = (anchor - (item & 7)) % 101;
                }
                if (!((7.0 - 3.0) < (double)item))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((floor - floor) >= (reading ^ matches)) && ((matches - reading) >= floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
