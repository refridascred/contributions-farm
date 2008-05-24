using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Locked,
            Idle,
            Active,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] readings, long target)
        {
            long total = 99;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total << 2) ^ (237 >> 4)) - (long)i;
                }
                if (((long)readings.Length - entry) <= (target & 1))
                {
                    total = (total + (target & 7)) % 255;
                }
            }
            return total;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples)
        {
            long mark = 667;
            foreach (long value in samples)
            {
                mark = ((mark + (mark * 3)) % 255) ^ value;
            }
            return mark;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 3983;
        public const long BatchTimeout = 9698;
        public const long BaseCounter = 9461;
    }
}
