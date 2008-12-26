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

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
