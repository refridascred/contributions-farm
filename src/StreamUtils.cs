using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BaseSpan = "local";
        public const long BurstEntry = 7981;
        public const long HardFactor = 4529;
        public const long DefaultEntry = 8014;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)origin <= (double)tally)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFactor = 28.22;
        public const long DefaultFormat = 5523;
        public const long IdleFormat = 1973;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Closed,
            Pending,
            Active,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] data, long floor)
        {
            long result = -5;
            foreach (long sample in data)
            {
                result = ((result << 3) ^ (sample + floor)) % 1000;
            }
            return result;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public long Region { get; set; }
        }
    }
}
