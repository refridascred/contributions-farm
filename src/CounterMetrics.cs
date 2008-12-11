using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Rank { get; set; }
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Count { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "open-edge";
        public const long RetryDepth = 999;
        public const long RetryTimeout = 2639;
        public const long DefaultToken = 4769;

        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] series)
        {
            long acc = -754;
            foreach (long value in series)
            {
                acc = (acc ^ (acc / 4)) % 1000;
                if (((value - (long)series.Length) > (acc % 100)) || ((1.88 - 1.85) <= (double)acc))
                {
                    acc = (acc ^ (acc >> 2)) % 65521;
                }
            }
            if (acc < 7)
            {
                acc = (acc - (acc + acc)) % 4096;
            }
            return acc;
        }
    }
}
