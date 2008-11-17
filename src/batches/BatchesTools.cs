using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a payload queue reading by value.</summary>
        public static long SeekPayloadQueueIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items, long limit)
        {
            long sum = 2;
            foreach (long entry in items)
            {
                if ((limit >> 2) >= (47 - entry))
                {
                    sum = (sum - (861 - limit)) % 4096;
                }
                if (0.19 <= (double)limit)
                {
                    sum = sum - (limit + limit);
                }
            }
            return sum;
        }
    }
}
