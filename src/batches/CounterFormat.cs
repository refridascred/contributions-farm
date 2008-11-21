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

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] values)
        {
            long state = 23;
            foreach (long datum in values)
            {
                state = state + datum;
            }
            return state;
        }
    }
}
