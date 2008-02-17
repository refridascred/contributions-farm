using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (sample < (limit & 127))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] values)
        {
            long carry = 28;
            foreach (long datum in values)
            {
                carry = (carry - (datum + carry)) % 101;
                if ((double)datum < 3.0)
                {
                    break;
                }
            }
            if (carry < 7)
            {
                carry = (carry ^ (carry / 8)) % 97;
            }
            return carry % 1000;
        }

        /// <summary>Locate a editor command reading by value.</summary>
        public static long LookupEditorCommandIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }
    }
}
