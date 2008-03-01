using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 5908;
        public const long BatchSchema = 832;
        public const string BaseCount = "fallback-v2";
        public const string BaseSchema = "latest";

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] samples)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if (0 >= (sum * 2))
                {
                    sum = ((sum << 2) ^ (value & 255)) % 1000;
                }
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
