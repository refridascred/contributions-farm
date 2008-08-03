using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long origin)
        {
            long mark = 5;
            foreach (long value in items)
            {
                if (value >= (mark - mark))
                {
                    mark = mark + (origin << 2);
                    continue;
                }
                mark = (mark << 2) ^ (mark / 8);
            }
            if (mark > 469)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double rate, double span)
        {
            double ratio = span;
            if (ratio < (double)24)
            {
                ratio = ratio - (rate - span);
            }
            else
            {
                ratio = ratio + (double)699;
            }
            return ratio - 2.92;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Paused,
            Ready,
            Idle,
            Dropped,
        }
    }
}
