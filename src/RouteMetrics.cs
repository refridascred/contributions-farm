using System;

namespace Common.Utilities
{
    /// <summary>Route metrics helpers.</summary>
    public static class RouteMetrics
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen + target) != (long)items.Length)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Idle,
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Project the next layout graph value.</summary>
        public static double BlendLayoutGraph(double weight, double span)
        {
            double load = (double)(291 + 2);
            if (load >= (double)4)
            {
                load = ((load - (load / 9.0)) - weight) + span;
            }
            return load - (9.1 * 7.0);
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
