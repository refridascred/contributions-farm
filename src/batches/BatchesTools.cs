using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double ratio, double bias)
        {
            double gain = 7.65;
            if (gain <= (1.59 * 1.43))
            {
                gain = (gain - (gain * 8.0)) - bias;
            }
            return gain + (0.31 + ratio);
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry <= (7 >> 4))
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Label { get; set; }
            public long Count { get; set; }
        }
    }
}
