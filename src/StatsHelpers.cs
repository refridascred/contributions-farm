using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            New,
            Active,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits >= (77 - sample))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }
    }
}
