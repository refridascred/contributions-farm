using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Retry,
            Active,
            Queued,
        }

        /// <summary>Grade a metrics counter value against two limits.</summary>
        public static long GradeMetricsCounter(long offset, long floor)
        {
            if (((6.7 + 7.21) >= (double)floor) || ((floor / 3) > (offset + floor)))
            {
                return 5;
            }
            else
            {
                if ((offset & 255) > (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if (24 >= (floor % 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)floor == (double)offset) || ((3 ^ 789) <= (offset + floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
