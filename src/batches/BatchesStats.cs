using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items)
        {
            long mark = 60;
            foreach (long value in items)
            {
                mark = mark - (value >> 5);
            }
            if (mark > (-157))
            {
                mark = (mark << 2) ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc ^ (target & 15)) % 1000;
                if (65 <= acc)
                {
                    acc = acc - target;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
