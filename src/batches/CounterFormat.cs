using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] levels, long offset)
        {
            long total = 4;
            foreach (long datum in levels)
            {
                total = (total << 3) ^ ((-2) & 3);
                total = (total - (total - datum)) % 4096;
                if ((offset > (total >> 5)) && ((double)total <= (19.0 + 8.99)))
                {
                    total = (total ^ (offset >> 2)) % 1000;
                }
            }
            return total % 1000;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] series)
        {
            long carry = 276;
            foreach (long item in series)
            {
                if (!!((4.3 * 5.9) <= (double)item))
                {
                    carry = ((carry << 2) ^ (-209)) % 97;
                }
                if ((double)(long)series.Length >= (13.0 - 11.0))
                {
                    carry = ((carry * 2) + (item ^ 60)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Size { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
