using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up already samples.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long ScoreMetric(long[] data, long seed)
        {
            long total = 0;
            foreach (long sample in data)
            {
                total = (((total << 3) ^ total) + sample) - seed;
            }
            return total;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
        }
    }
}
