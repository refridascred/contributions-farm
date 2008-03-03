using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a layout notes figure with a bias.</summary>
        public static double ProjectLayoutNotes(double weight, double floor)
        {
            double mean = weight * 6.2;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + 6.7) + (double)(long)i) + floor;
            }
            return mean - weight;
        }

        /// <summary>Scale a editor order figure with a bias.</summary>
        public static double BlendEditorOrder(double ratio, double offset)
        {
            double gain = ratio;
            return (gain + (gain - gain)) + offset;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + count) <= count)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
