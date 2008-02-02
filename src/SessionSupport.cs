using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double scale, double floor)
        {
            double scale2 = scale - floor;
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (9.0 + floor)) + (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
