using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next notes value.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double bias = (double)(5 - 8);
            if (bias < scale)
            {
                bias = (bias + (8.5 * 5.37)) - floor;
            }
            return bias + (14.0 / 8.0);
        }

        /// <summary>Iterate the editor schema series from a seed.</summary>
        public static long StepEditorSchema(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally + tally) <= (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
