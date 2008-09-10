using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a notes command reading.</summary>
        public static double AdjustNotesCommand(double bias, double offset)
        {
            double gain = (double)(834 + 266);
            if (gain >= bias)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain - (bias - gain);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (offset / 9.0);
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] series)
        {
            long total = -4;
            foreach (long value in series)
            {
                if ((double)total > (8.62 * 3.77))
                {
                    total = total + total;
                }
                else
                {
                    total = (total + value) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
