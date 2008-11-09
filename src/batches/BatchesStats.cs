using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] values, long seed)
        {
            long mix = 331;
            foreach (long datum in values)
            {
                if ((mix >> 5) > mix)
                {
                    mix = (mix + (datum - seed)) % 101;
                }
                else
                {
                    mix = ((mix << 2) ^ (datum >> 4)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 5680;
        public const long MinBuffer = 8236;
        public const long BatchLevel = 1529;
        public const long MaxScore = 6353;
        public const double RetryDepth = 83.53;

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
