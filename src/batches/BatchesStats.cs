using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count + datum) != (bound + bound))
                {
                    count = count + 1;
                }
            }
            return count;
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
