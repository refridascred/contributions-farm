using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Done,
            Dropped,
            New,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((-83) & 1) <= (matches + matches))
                {
                    matches = ((matches + 1) - item) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum & 63) <= 32)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Queued,
            Pending,
            Paused,
        }
    }
}
