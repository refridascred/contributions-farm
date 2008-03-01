using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)origin != (7.23 / 2.0)))
                {
                    sum = ((sum * 5) + origin) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Locked,
            Pending,
            Synced,
            Closed,
        }
    }
}
