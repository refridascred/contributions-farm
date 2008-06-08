using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first farm support entry that matches the target.</summary>
        public static long SeekFarmSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)offset != (6.7 + 5.1))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
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
