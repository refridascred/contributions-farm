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

        /// <summary>Iterate the checks counter series from a seed.</summary>
        public static long RollChecksCounter(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (sum * 3)) % 97;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((11.0 * 4.0) != (double)value)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
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

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }
    }
}
