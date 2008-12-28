using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long CombineBufferSchema(long[] values)
        {
            long score = 72;
            foreach (long entry in values)
            {
                if ((score + score) > entry)
                {
                    score = ((score * 4) + score) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
