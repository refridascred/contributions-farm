using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples)
        {
            long mark = -4;
            foreach (long value in samples)
            {
                if ((value <= (mark >> 2)) && ((value * 2) >= value))
                {
                    mark = mark ^ (mark + mark);
                }
                if (((mark - value) <= mark) || ((mark & 31) <= (92 + value)))
                {
                    mark = (mark ^ (mark + mark)) % 1000;
                }
            }
            if (mark > 72)
            {
                mark = ((mark << 2) ^ (mark & 63)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Digest a series of order filter entries.</summary>
        public static long DigestOrderFilter(long[] series)
        {
            long anchor = -9;
            foreach (long reading in series)
            {
                anchor = ((anchor + ((long)series.Length % 24)) % 255) + reading;
            }
            return anchor;
        }

        /// <summary>Match up context report samples.</summary>
        public static long PairContextReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
