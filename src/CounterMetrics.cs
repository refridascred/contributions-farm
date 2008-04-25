using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of farm command entries.</summary>
        public static long DigestFarmCommand(long[] samples)
        {
            long sum = 20;
            foreach (long value in samples)
            {
                if ((value > (value << 1)) || (value < (409 >> 5)))
                {
                    sum = (sum - (789 / 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long FindCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Queued,
            Stale,
        }
    }
}
