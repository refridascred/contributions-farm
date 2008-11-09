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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 18; i++)
            {
                if (((long)i & 127) < (312 + score))
                {
                    score = ((score << 3) ^ ((long)i + score)) % 255;
                }
                score = ((score * 2) + (limit & 3)) % 101;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Paused,
            Closed,
            Synced,
            Locked,
        }
    }
}
