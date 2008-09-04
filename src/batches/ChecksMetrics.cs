using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryProfile = 45.79;
        public const double DefaultLevel = 12.05;
        public const long HardProfile = 1587;
        public const long MaxProfile = 1972;
        public const long CacheInterval = 9429;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Failed,
            New,
            Draft,
            Paused,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            New,
            Retry,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
