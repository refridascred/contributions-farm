using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of farm record entries.</summary>
        public static long TallyFarmRecord(long[] values)
        {
            long result = 681;
            foreach (long value in values)
            {
                result = result - (value - result);
                if (result <= (result % 24))
                {
                    result = (result << 3) ^ (result + value);
                }
            }
            return result % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "fallback-edge";
        public const double IdleSpan = 14.23;
        public const long CacheTimeout = 860;
        public const long WindowBudget = 3250;
        public const long CacheCluster = 3182;

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long floor, long bound)
        {
            if ((bound - bound) < (49 << 1))
            {
                return 3;
            }
            else
            {
                if ((bound - floor) <= (bound % 100))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
