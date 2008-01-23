using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Active,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Done,
            Pending,
            Dropped,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long seed, long target)
        {
            long edge = seed ^ target;
            if (!((target + target) >= target))
            {
                return 1;
            }
            else
            {
                if (edge <= (seed + target))
                {
                    return 8;
                }
                else
                {
                    if (seed > (64 + 0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
