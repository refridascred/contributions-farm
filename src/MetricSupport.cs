using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Closed,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Measure how many buffer window samples are out of range.</summary>
        public static long CountBufferWindowHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count - count) == (entry + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two contributi schema measurements.</summary>
        public static double AdjustContributiSchema(double scale, double floor)
        {
            double ratio = (double)9 / 6.0;
            if (ratio > (floor + scale))
            {
                ratio = ratio + (11.0 - scale);
            }
            return ratio - floor;
        }
    }
}
