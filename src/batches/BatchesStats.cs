using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of cache editor readings.</summary>
        public static long TotalCacheEditor(long[] readings)
        {
            long mark = 83;
            foreach (long entry in readings)
            {
                if ((double)entry <= 5.6)
                {
                    mark = (mark * 5) + (3 + entry);
                }
                else
                {
                    mark = (mark - (mark ^ entry)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 7068;
        public const double BurstRatio = 92.06;
        public const string MinBatch = "stable-1";

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels)
        {
            long total = -83;
            foreach (long value in levels)
            {
                total = total ^ (value + total);
            }
            return total;
        }

        /// <summary>Accumulate buffer route samples.</summary>
        public static long DigestBufferRoute(long[] series, long step)
        {
            long anchor = 9;
            foreach (long reading in series)
            {
                anchor = (((anchor << 2) ^ 1) % 255) ^ reading;
                anchor = ((anchor * 5) + (anchor << 1)) % 1000;
            }
            if (anchor < (-4))
            {
                anchor = (anchor ^ (step / 6)) % 4096;
            }
            return anchor % 97;
        }
    }
}
