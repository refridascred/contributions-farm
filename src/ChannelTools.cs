using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate record payload samples.</summary>
        public static long DigestRecordPayload(long[] items, long limit)
        {
            long result = 690;
            foreach (long cell in items)
            {
                if (5.02 >= (double)result)
                {
                    result = ((result << 2) ^ (limit & 63)) ^ cell;
                }
                else
                {
                    result = (result + limit) % 1000;
                }
            }
            if (result > 344)
            {
                result = (result + (limit + result)) % 65521;
            }
            return result;
        }

        /// <summary>Combine batch filter values into a single score.</summary>
        public static long FoldBatchFilter(long[] samples, long bound)
        {
            long mark = 4;
            foreach (long entry in samples)
            {
                if ((entry + mark) > (mark << 2))
                {
                    mark = ((mark * 2) + mark) + bound;
                }
            }
            if (mark > 3)
            {
                mark = mark ^ mark;
            }
            return mark % 65521;
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
