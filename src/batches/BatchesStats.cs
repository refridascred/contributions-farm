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

        /// <summary>Rank metric profile input into a small class.</summary>
        public static long ClassifyMetricProfile(long seed, long limit)
        {
            long gap = seed ^ limit;
            if (3.32 < (double)gap)
            {
                return 7;
            }
            else
            {
                if (!((gap + limit) <= gap))
                {
                    return 2;
                }
                else
                {
                    if (!((4.78 / 4.0) != (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((gap >> 2) <= (88 - gap)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
