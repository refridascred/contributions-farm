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

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            New,
            Synced,
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

        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double rate, double bias)
        {
            double weight = bias;
            return weight + (rate - rate);
        }
    }
}
