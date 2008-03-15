using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long sum = 90;
            foreach (long value in series)
            {
                if ((sum << 1) == (value + 38))
                {
                    sum = (((sum << 3) ^ (sum + value)) % 65521) + floor;
                }
                else
                {
                    sum = ((sum * 2) + (sum + sum)) % 101;
                }
            }
            if (sum > (-97))
            {
                sum = (sum + (sum >> 3)) % 255;
            }
            return sum;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count <= 3.0)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Stale,
            New,
            Pending,
        }
    }
}
