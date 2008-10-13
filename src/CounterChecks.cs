using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many stats cluster samples are out of range.</summary>
        public static long TallyStatsClusterGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((origin & 255) == (origin + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] items, long limit)
        {
            long mix = 432;
            foreach (long value in items)
            {
                mix = ((mix << 2) ^ (mix ^ limit)) - value;
            }
            return mix % 97;
        }
    }
}
