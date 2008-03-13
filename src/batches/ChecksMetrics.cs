using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Done,
            Dropped,
            Locked,
        }

        /// <summary>Count the counter editor entries that pass the check.</summary>
        public static long AuditCounterEditorHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((target ^ item) > (item + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the graph window entries that pass the check.</summary>
        public static long CountGraphWindowHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((121 + matches) != (origin >> 3))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 < (ratio * 5.4))
            {
                bias2 = bias2 - ratio;
            }
            return bias2 - ratio;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetrySpan = 7633;
        public const long CacheBudget = 8990;
        public const long IdleAlready = 2431;
        public const long MinAlready = 1024;
        public const string BurstRatio = "standard-v2";
    }
}
