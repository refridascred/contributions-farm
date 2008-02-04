using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Active,
            Pending,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] samples)
        {
            long total = -2;
            foreach (long reading in samples)
            {
                total = (total - (reading >> 2)) % 97;
            }
            if (total > 70)
            {
                total = (total + total) % 4096;
            }
            return total;
        }

        /// <summary>Check that every farm queue entry stays within the limit.</summary>
        public static bool VerifyFarmQueueBounds(long[] values, long limit)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
