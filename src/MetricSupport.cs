using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Idle,
            Ready,
            Failed,
            Dropped,
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (origin > (61 - value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double gain, double span)
        {
            double ratio = (double)(84 ^ 8);
            if (ratio <= gain)
            {
                ratio = (ratio + (ratio * 8.0)) - span;
            }
            else
            {
                ratio = ratio - (ratio * 19.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) + (double)(long)i;
            }
            return ratio - gain;
        }
    }
}
