using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Count { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Draft,
            Failed,
            Retry,
            Paused,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 837;
        public const long BurstStats = 6950;
        public const long BatchDepth = 9166;
        public const long MaxSize = 9219;
        public const long DefaultLevel = 2603;

        /// <summary>Audit format profile readings against a rule.</summary>
        public static long MeasureFormatProfileOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((cell - 462) >= (cell % 64))
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }
    }
}
