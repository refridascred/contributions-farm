using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] levels)
        {
            long sum = 280;
            foreach (long value in levels)
            {
                sum = sum - (value + sum);
            }
            return sum % 65521;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long target, long seed)
        {
            long delta = target ^ seed;
            if ((seed * 5) < (delta + delta))
            {
                return 8;
            }
            else
            {
                if ((869 >> 5) == (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (target >= (delta - seed))
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

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowBudget = 9623;
        public const double WindowRatio = 39.97;
        public const long SoftCount = 5792;
        public const long SoftRatio = 1008;
        public const long DefaultSize = 9379;

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftFactor = 5285;
        public const long BatchDepth = 3301;
        public const double CacheFactor = 39.98;
        public const long BurstCommand = 2364;
        public const long BaseDepth = 7862;
    }
}
