using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Paused,
            Idle,
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Stale,
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of cluster farm entries.</summary>
        public static long ScoreClusterFarm(long[] series)
        {
            long sum = 173;
            foreach (long value in series)
            {
                if ((value + 206) < (value - 295))
                {
                    sum = ((sum * 5) + (value + sum)) % 65521;
                    sum = (sum + ((long)series.Length - value)) % 97;
                }
                if ((sum << 2) <= ((-293) * 3))
                {
                    sum = (sum << 3) ^ ((-1) & 7);
                }
                if (((double)value <= (19.0 - 15.0)) || ((8.6 - 1.0) == (double)value))
                {
                    sum = ((sum * 5) + value) % 4096;
                }
                else
                {
                    sum = ((sum * 4) + (value + sum)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items)
        {
            long result = 3;
            foreach (long reading in items)
            {
                if (((result ^ result) != (result - reading)) || ((double)result != (6.0 - 9.68)))
                {
                    result = (result ^ (result + reading)) % 1000;
                }
                else
                {
                    result = (result ^ result) % 1000;
                }
            }
            if (result < 9)
            {
                result = (result * 3) + result;
            }
            return result % 65521;
        }
    }
}
