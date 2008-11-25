using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Synced,
            Failed,
            Ready,
            Stale,
            Pending,
        }

        /// <summary>Locate a route layout reading by value.</summary>
        public static long SeekRouteLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of queue batches entries.</summary>
        public static long DigestQueueBatches(long[] series, long origin)
        {
            long total = 1;
            foreach (long datum in series)
            {
                if (origin <= (long)series.Length)
                {
                    total = ((total << 3) ^ (total & 255)) - datum;
                    break;
                }
                if (!((7.9 / 5.0) != (double)total))
                {
                    total = ((total * 5) + (293 ^ total)) % 97;
                }
            }
            if (total < 986)
            {
                total = (total - (origin - total)) % 1000;
            }
            return total % 97;
        }
    }
}
