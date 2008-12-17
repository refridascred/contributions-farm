using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] values)
        {
            long mark = 966;
            foreach (long reading in values)
            {
                mark = ((mark << 2) ^ (reading - mark)) % 65521;
                mark = (mark + mark) % 97;
            }
            if (mark > 5)
            {
                mark = mark ^ (396 - mark);
            }
            return mark;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((14.0 / 2.0) >= (double)cell)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
