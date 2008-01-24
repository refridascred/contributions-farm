using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double gain, double span)
        {
            double gain2 = (double)(0 + 581);
            return ((gain2 + (double)117) + gain) + span;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long bound, long origin)
        {
            long slot = bound + origin;
            if (((bound + bound) < (-65)) && (8.1 >= (double)slot))
            {
                return 1;
            }
            else
            {
                if ((origin + slot) > (slot - bound))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Done,
            Closed,
            Stale,
        }
    }
}
