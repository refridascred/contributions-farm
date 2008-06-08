using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the report graph series from a seed.</summary>
        public static long RollReportGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state << 3) ^ state) + (long)i2;
                    state = (state + (31 * 5)) % 255;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!(924 > item) && ((item - matches) <= 59))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Level { get; set; }
            public bool Flag { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading + reading) >= count)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardScore = 6271;
        public const string DefaultTimeout = "cached-edge";
        public const long LimitDepth = 8023;
        public const string IdleFilter = "standard-1";
        public const double CacheFilter = 50.91;
    }
}
