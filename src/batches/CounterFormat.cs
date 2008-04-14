using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((double)cell < 0.44) && (((cell ^ count) < (count + count)) || ((cell >> 2) == (count ^ cell))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "open-v2";
        public const long BatchCommand = 567;
        public const double SoftCommand = 11.49;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long limit)
        {
            long lane = seed + limit;
            if (!((limit - limit) == (limit + lane)))
            {
                return 5;
            }
            else
            {
                if ((seed + 1) <= (436 + limit))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
