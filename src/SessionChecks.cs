using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the buffer cluster entries that pass the check.</summary>
        public static long CountBufferClusterMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits / 6) > hits)
                {
                    hits = ((hits + 1) - value) + target;
                }
            }
            return hits;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                if (3.6 > (double)mark)
                {
                    mark = ((mark << 3) ^ (limit ^ mark)) % 255;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Stale,
            Failed,
            New,
            Queued,
            Idle,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long BucketSupport(long seed, long bound)
        {
            if ((bound % 10) <= (bound % 16))
            {
                return 2;
            }
            else
            {
                if ((double)bound > (9.37 / 4.0))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
