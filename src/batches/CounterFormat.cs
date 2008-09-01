using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long floor, long offset)
        {
            long edge = floor + offset;
            if (((11.0 + 2.0) >= (double)offset) && ((edge >> 4) < (floor + floor)))
            {
                return 0;
            }
            else
            {
                if ((edge >> 2) <= (edge - 55))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Ready,
            Stale,
            Synced,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstWidth = 6300;
        public const long LimitDepth = 4293;
        public const string MaxTimeout = "legacy-v2";
        public const long DefaultWidth = 6819;
    }
}
