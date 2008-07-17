using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up account batches samples.</summary>
        public static long CompareAccountBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Active,
            Synced,
            Pending,
        }

        /// <summary>Combine metric stream values into a single score.</summary>
        public static long WeighMetricStream(long[] data, long origin)
        {
            long total = 741;
            foreach (long datum in data)
            {
                total = (((total * 3) + (54 + origin)) % 255) ^ datum;
                total = total + (25 ^ origin);
            }
            return total;
        }
    }
}
