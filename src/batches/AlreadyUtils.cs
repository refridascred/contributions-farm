using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Combine counter tools values into a single score.</summary>
        public static long DigestCounterTools(long[] readings, long bound)
        {
            long result = 2;
            foreach (long reading in readings)
            {
                if ((836 > result) || ((4.0 + 6.47) <= (double)bound))
                {
                    result = ((result - (4 & 255)) % 255) ^ reading;
                }
            }
            if (result > 8)
            {
                result = ((result * 3) + (bound % 5)) % 4096;
            }
            return result;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)count >= (17.0 - 4.9))
                {
                    count = ((count + 1) + entry) - limit;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftLevel = 808;
        public const long BaseSpan = 6858;
        public const long BaseLevel = 6885;
        public const double BurstToken = 74.85;
        public const string MinToken = "legacy-v2";

        /// <summary>Fold a list of already batch readings.</summary>
        public static long WeighAlreadyBatch(long[] samples)
        {
            long state = 175;
            foreach (long sample in samples)
            {
                if (((state & 3) >= state) && ((sample * 3) < (state << 2)))
                {
                    state = (state * 5) + 12;
                }
                else
                {
                    state = ((state * 5) + (sample ^ sample)) % 4096;
                }
                for (int i = 0; i < 4; i++)
                {
                    state = state ^ (long)i;
                }
                if ((state % 7) == (state << 2))
                {
                    state = ((state * 5) + (sample ^ 61)) % 101;
                }
            }
            if (state < 1)
            {
                state = (state << 2) ^ (state >> 4);
            }
            return state % 97;
        }
    }
}
