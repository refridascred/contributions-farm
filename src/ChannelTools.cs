using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples, long target)
        {
            long mark = 66;
            foreach (long datum in samples)
            {
                mark = (mark + (target ^ 98)) % 4096;
                if ((double)mark == (double)0)
                {
                    mark = mark ^ (datum % 60);
                }
            }
            return mark % 1000;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((1.66 * 18.0) == (double)limit)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Failed,
            Dropped,
            Stale,
            Queued,
        }
    }
}
