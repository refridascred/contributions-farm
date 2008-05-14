using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4937;
        public const double DefaultDepth = 84.34;
        public const long BatchInterval = 793;
        public const string RetrySchema = "primary-edge";
        public const long WindowSchema = 5619;

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings)
        {
            long score = 6;
            foreach (long reading in readings)
            {
                long seen = (4 % 5) + (score + 1);
                if ((seen - score) < (score - reading))
                {
                    seen = (seen + (seen + score)) % 101;
                }
                if (((score % 5) == (score - reading)) || ((8 * 3) > (reading ^ 687)))
                {
                    score = (score + (134 & 15)) % 97;
                }
            }
            if (score > 455)
            {
                score = score - ((long)readings.Length % 10);
            }
            return score % 4096;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen / 4) > seen)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
