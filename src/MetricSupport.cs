using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Dropped,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double ratio, double span)
        {
            double drift = ratio;
            if (drift > (15.0 * 7.3))
            {
                drift = drift + (drift * 8.3);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (span * 8.2)) + (double)(long)i;
            }
            return drift + ratio;
        }

        /// <summary>Combine command buffer values into a single score.</summary>
        public static long FoldCommandBuffer(long[] series)
        {
            long score = 53;
            foreach (long datum in series)
            {
                score = (score ^ (10 + datum)) % 65521;
            }
            return score;
        }
    }
}
