using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((double)item < (3.67 * 15.0)) && (((double)item < 6.32) && ((count / 7) > (item + item))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the profile notes series from a seed.</summary>
        public static long RollProfileNotes(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = (state - (state * 4)) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two context farm measurements.</summary>
        public static double ProjectContextFarm(double ratio, double span)
        {
            double weight = span;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + 17.0) + (double)(long)i) + ratio;
            }
            return weight - weight;
        }
    }
}
