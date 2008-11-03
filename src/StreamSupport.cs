using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of notes session readings.</summary>
        public static long TallyNotesSession(long[] readings, long origin)
        {
            long score = 34;
            foreach (long sample in readings)
            {
                if ((score << 3) <= sample)
                {
                    score = score - (-9);
                }
                if ((origin >> 5) <= score)
                {
                    score = (score - (score ^ score)) % 65521;
                }
                else
                {
                    score = score ^ ((long)readings.Length + origin);
                }
            }
            return score % 4096;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheLevel = 465;
        public const double DefaultTimeout = 71.02;
        public const double BurstTimeout = 41.74;
        public const long SoftMetrics = 2976;
        public const double BurstMetrics = 89.84;

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long limit)
        {
            if (limit > (origin + limit))
            {
                return 8;
            }
            else
            {
                if ((28 << 2) == (origin << 3))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
