using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long step, long bound)
        {
            long next = step ^ bound;
            if ((step % 16) < (bound ^ bound))
            {
                return 1;
            }
            else
            {
                if ((step + next) < (next - next))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a farm tools sample.</summary>
        public static long LookupFarmToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Audit tools channel readings against a rule.</summary>
        public static long MeasureToolsChannelMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((seed & 127) < (seed + cell))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Pending,
            Closed,
            Draft,
            Dropped,
        }
    }
}
