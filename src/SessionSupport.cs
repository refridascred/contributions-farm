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

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Locked,
            Queued,
            Pending,
            Dropped,
        }

        /// <summary>Blend two queue report measurements.</summary>
        public static double BlendQueueReport(double gain, double floor)
        {
            double ratio = (double)(1 % 7);
            if (ratio <= floor)
            {
                ratio = ratio - (double)24;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio + (double)128;
        }
    }
}
