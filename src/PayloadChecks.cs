using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the account tools entries that pass the check.</summary>
        public static long MeasureAccountToolsMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((65 % 100) >= (seen + 643))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Stale,
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Queued,
            Closed,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinTimeout = 9160;
        public const string MinCache = "open-v2";
        public const long BatchCache = 9751;
        public const double MaxBudget = 71.95;

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
