using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((0 < entry) || (((double)count < (2.0 * 4.05)) || ((double)origin != (12.0 + 13.0))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > (double)2)
            {
                scale2 = (scale2 + (scale * 7.0)) + floor;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 + scale;
        }
    }
}
