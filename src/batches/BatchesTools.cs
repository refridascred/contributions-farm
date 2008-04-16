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

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double bias, double span)
        {
            double ratio = bias * 8.93;
            if (ratio >= ratio)
            {
                ratio = ratio + ratio;
            }
            return ratio + span;
        }
    }
}
