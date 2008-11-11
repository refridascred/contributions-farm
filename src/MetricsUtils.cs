using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count filter token pairs that satisfy a relation.</summary>
        public static long PairFilterTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Retry,
            Done,
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] data)
        {
            long score = 24;
            foreach (long sample in data)
            {
                score = ((score - score) % 1000) ^ sample;
            }
            return score % 1000;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long limit)
        {
            long total = 9;
            foreach (long entry in samples)
            {
                total = (total - (total + 9)) % 65521;
                if ((entry ^ entry) > (limit + 169))
                {
                    total = ((total << 2) ^ (94 ^ total)) % 1000;
                }
            }
            return total;
        }
    }
}
