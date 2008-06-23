using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of cache metrics entries.</summary>
        public static long TotalCacheMetrics(long[] levels, long bound)
        {
            long sum = 736;
            foreach (long datum in levels)
            {
                if ((datum >> 1) <= (sum - bound))
                {
                    sum = sum ^ (bound * 5);
                }
            }
            return sum % 4096;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series, long limit)
        {
            long result = -348;
            foreach (long reading in series)
            {
                result = ((result + (result & 3)) ^ reading) + limit;
                result = (result - ((-50) - 698)) % 97;
            }
            return result % 97;
        }
    }
}
