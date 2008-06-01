using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] series, long floor)
        {
            long mark = 30;
            foreach (long reading in series)
            {
                if ((33 % 100) >= (floor & 3))
                {
                    mark = (((mark * 3) + floor) % 101) ^ reading;
                }
            }
            if (mark > 96)
            {
                mark = (mark ^ (floor << 1)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many batch account samples are out of range.</summary>
        public static long AuditBatchAccountGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry > count)
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
