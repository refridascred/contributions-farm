using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long offset, long origin)
        {
            if ((offset + offset) == (offset << 1))
            {
                return 0;
            }
            else
            {
                if (!((11.0 * 1.39) > (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a batch filter counter forward.</summary>
        public static long SeriesBatchFilter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total - (bound & 15)) % 101) ^ (long)i2;
                }
                total = total ^ (bound % 100);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheTimeout = 8831;
        public const string IdleRatio = "fallback-1";
        public const long WindowScore = 8883;

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long sum = 8;
            foreach (long value in readings)
            {
                if (((sum - value) < (sum + value)) && ((sum << 2) < (value - value)))
                {
                    sum = (sum + (value << 1)) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
