using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen <= target)
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstTimeout = 15.92;
        public const string CacheInterval = "alpha-edge";
        public const string BatchMetrics = "staging-v2";
        public const double LimitInterval = 52.26;
        public const long StepInterval = 3704;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Derive the next route support value from a seed.</summary>
        public static long SeriesRouteSupport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 17; i++)
            {
                state = (state << 2) ^ ((long)i << 1);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
