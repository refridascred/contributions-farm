using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count + count) <= (value >> 2))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (scale - gain)) + (double)(long)i;
            }
            return gain + (9.69 * 3.8);
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Active,
            Draft,
            Pending,
            Ready,
            Stale,
        }
    }
}
