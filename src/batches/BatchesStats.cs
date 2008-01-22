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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long offset, long step)
        {
            if ((step * 3) > (offset - step))
            {
                return 1;
            }
            else
            {
                if (((step << 2) == (offset + step)) || (offset > (step * 2)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
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
