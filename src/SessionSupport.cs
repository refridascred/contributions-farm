using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = state - ((long)i - step);
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + cell) < (cell ^ cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)tally < (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
