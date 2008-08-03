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

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long limit, long target)
        {
            if ((double)target >= (6.0 / 6.0))
            {
                return 3;
            }
            else
            {
                if (target > limit)
                {
                    return 0;
                }
                else
                {
                    if (72 < (target + target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target / 4) <= (225 * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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
