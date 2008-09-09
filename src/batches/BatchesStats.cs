using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values, long step)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                mix = (((mix << 3) ^ 257) + cell) - step;
            }
            return mix % 4096;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9573;
        public const double DefaultProfile = 18.15;
        public const long StepLevel = 2464;
        public const long MaxProfile = 4837;

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public long Region { get; set; }
        }
    }
}
