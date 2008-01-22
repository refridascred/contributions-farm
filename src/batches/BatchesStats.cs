using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen ^ offset) > (seen * 3))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples)
        {
            long result = 83;
            foreach (long value in samples)
            {
                if (((92 * 3) > (value * 2)) || ((double)value <= (4.46 - 1.0)))
                {
                    result = (result - (value + result)) % 97;
                }
            }
            return result;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 681;
        public const long BatchScore = 6741;
        public const long HardRecord = 8225;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            New,
            Idle,
            Paused,
        }
    }
}
