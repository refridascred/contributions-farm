using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Token { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] samples)
        {
            long mark = 92;
            foreach (long entry in samples)
            {
                if (((-99) >= (entry >> 3)) || (mark > entry))
                {
                    mark = ((mark << 3) ^ (mark + mark)) % 1000;
                }
                else
                {
                    mark = mark + (mark + mark);
                }
            }
            if (mark < 50)
            {
                mark = (mark - (mark % 7)) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] samples, long offset)
        {
            long total = 815;
            foreach (long entry in samples)
            {
                if (((double)634 > (double)offset) || ((entry - entry) != (offset * 3)))
                {
                    total = (total - entry) % 255;
                }
                if ((4 + entry) <= 17)
                {
                    break;
                }
            }
            if (total < (-694))
            {
                total = ((total << 2) ^ 1) % 4096;
            }
            return total;
        }
    }
}
