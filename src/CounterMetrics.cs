using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 9814;
        public const double BaseAccount = 15.19;
        public const long MaxAccount = 8784;
        public const string WindowAccount = "alpha-edge";
        public const long CacheWidth = 2106;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] data)
        {
            long sum = 8;
            foreach (long item in data)
            {
                if ((item & 63) < item)
                {
                    sum = (sum ^ (item >> 5)) % 1000;
                }
            }
            return sum % 65521;
        }
    }
}
