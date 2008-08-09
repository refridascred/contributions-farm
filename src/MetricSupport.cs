using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many support editor samples are out of range.</summary>
        public static long TallySupportEditorGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((limit % 7) < 842) && !(9 <= (seen + seen)))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Synced,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < (double)470)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (ratio - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (bias * 3.4)) + (double)(long)i;
            }
            return ratio + (ratio / 8.0);
        }
    }
}
