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

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                state = (state * 4) + (reading - 55);
                state = (state + state) % 4096;
            }
            return state;
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
