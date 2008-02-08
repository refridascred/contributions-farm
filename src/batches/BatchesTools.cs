using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double ratio, double span)
        {
            double gain = ratio + 6.0;
            if (gain >= (double)396)
            {
                gain = (gain + (gain + ratio)) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - ratio) + (double)(long)i;
            }
            return gain - ratio;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((24 * 2) > item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
