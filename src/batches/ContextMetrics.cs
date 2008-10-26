using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank schema editor input into a small class.</summary>
        public static long BucketSchemaEditor(long target, long floor)
        {
            long slot = target + floor;
            if ((double)target <= (double)slot)
            {
                return 2;
            }
            else
            {
                if ((slot << 2) >= (slot + 756))
                {
                    return 1;
                }
                else
                {
                    if ((4.36 * 3.25) >= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            New,
            Draft,
            Pending,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Paused,
            Retry,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 5923;
        public const long MaxDepth = 9731;
        public const long RetryScore = 590;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Failed,
            New,
            Idle,
            Draft,
        }
    }
}
