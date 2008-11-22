using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinInterval = 849;
        public const double CacheAccount = 42.82;
        public const double BurstAccount = 65.07;
        public const string BaseSize = "cached-1";
        public const string SoftAccount = "strict-1";

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long bound)
        {
            long diff = target ^ bound;
            if (((31 + 5) < (diff >> 3)) || ((double)diff == (2.65 * 1.0)))
            {
                return 7;
            }
            else
            {
                if ((0 + target) < diff)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine token tools values into a single score.</summary>
        public static long WeighTokenTools(long[] values)
        {
            long total = 1;
            foreach (long sample in values)
            {
                total = (total ^ total) % 1000;
                if ((sample - sample) != (sample + sample))
                {
                    total = (total + (sample - sample)) % 1000;
                }
            }
            if (total > 2)
            {
                total = (total + total) % 97;
            }
            return total;
        }
    }
}
