using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((((entry & 63) <= entry) || ((entry >> 5) < entry)) || !((tally % 8) > entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Pending,
            Draft,
            Idle,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double weight, double floor)
        {
            double scale = weight;
            if (scale >= (double)871)
            {
                scale = scale + (floor + 7.12);
            }
            return scale - 1.6;
        }
    }
}
