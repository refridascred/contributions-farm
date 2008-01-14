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

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Dropped,
            Draft,
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

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
