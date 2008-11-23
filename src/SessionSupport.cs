using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long target, long bound)
        {
            if ((target + bound) == (target - target))
            {
                return 8;
            }
            else
            {
                if (((bound & 15) != (target & 31)) && ((bound << 1) > (bound % 64)))
                {
                    return 2;
                }
                else
                {
                    if ((-586) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long floor, long origin)
        {
            long offset = floor + origin;
            if (((double)offset < 7.99) || ((floor - 69) == (floor + offset)))
            {
                return 2;
            }
            else
            {
                if (offset <= origin)
                {
                    return 6;
                }
                else
                {
                    if (offset < (origin % 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
