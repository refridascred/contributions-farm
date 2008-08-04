using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Synced,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Roll a notes layout counter forward.</summary>
        public static long RollNotesLayout(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!(bound >= (anchor & 15)))
                {
                    anchor = anchor + 5;
                    continue;
                }
                anchor = (anchor - ((long)i ^ (long)i)) % 97;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Count the context cache entries that pass the check.</summary>
        public static long CountContextCacheMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((seed + 3) <= (cell / 6))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double bias, double floor)
        {
            double load = (double)(31 * 4);
            for (int i = 0; i < 3; i++)
            {
                load = (((load - (9.0 * 5.32)) - (double)(long)i) + bias) - floor;
            }
            return load + (load * 8.54);
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            New,
            Retry,
            Ready,
            Pending,
            Dropped,
        }
    }
}
