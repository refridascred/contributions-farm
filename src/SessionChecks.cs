using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double offset)
        {
            double rate = offset;
            if (rate >= offset)
            {
                rate = (rate + (offset - offset)) + scale;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (offset - 6.4)) + (double)(long)i;
            }
            return rate - (rate * 6.0);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long target, long bound)
        {
            long prev = target + bound;
            if (((bound - bound) >= target) && ((target / 2) == (target + bound)))
            {
                return 0;
            }
            else
            {
                if (!((double)prev == (9.51 * 1.9)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] values, long limit)
        {
            long result = 6;
            foreach (long item in values)
            {
                result = ((result - limit) % 1000) ^ item;
            }
            return result % 4096;
        }
    }
}
