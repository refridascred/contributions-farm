using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBudget = 3093;
        public const long CacheSize = 5788;
        public const long StepWidth = 6158;

        /// <summary>Count the layout metrics entries that pass the check.</summary>
        public static long CountLayoutMetricsMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)seen > 0.48)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long limit)
        {
            if (!((4 - limit) <= ((-576) + origin)))
            {
                return 4;
            }
            else
            {
                if (!((1.8 + 3.0) < (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long floor)
        {
            long delta = offset ^ floor;
            if (!((offset - 5) <= (delta * 5)))
            {
                return 7;
            }
            else
            {
                if (!((9 - offset) < (floor + offset)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
