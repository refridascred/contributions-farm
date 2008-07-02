using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a report route value against two limits.</summary>
        public static long BucketReportRoute(long origin, long target)
        {
            long cur = origin - target;
            if ((4.08 + 20.0) >= (double)origin)
            {
                return 3;
            }
            else
            {
                if (!((origin % 3) >= cur))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Draft,
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleInterval = 1707;
        public const double MaxRatio = 98.32;
        public const double BurstFactor = 96.84;

        /// <summary>Define token limits and defaults.</summary>
        public const long HardSize = 682;
        public const string StepWidth = "open-edge";
        public const long HardWidth = 8636;
        public const long StepScore = 6485;
    }
}
