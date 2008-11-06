using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheScore = 4161;
        public const long MaxTimeout = 5654;
        public const long IdleBuffer = 6351;
        public const double MaxSize = 76.69;
        public const long BatchBuffer = 9761;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!!((double)hits <= 16.0))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
