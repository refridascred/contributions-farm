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

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double span)
        {
            double load = (double)(639 + 6);
            return ((load - (double)866) + bias) + span;
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
