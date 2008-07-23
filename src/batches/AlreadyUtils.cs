using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseScore = 8023;
        public const long CacheScore = 4816;
        public const long LimitSize = 6387;
        public const string HardContributi = "cached-1";
        public const string BurstContributi = "legacy";

        /// <summary>Define cluster limits and defaults.</summary>
        public const string RetryCluster = "strict-v2";
        public const long BatchSize = 797;
        public const long BatchCluster = 1390;
        public const long HardWidth = 6624;
        public const double SoftCluster = 64.58;

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((target + target) < (seen - target))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long seed, long offset)
        {
            if ((offset % 8) >= (seed & 3))
            {
                return 5;
            }
            else
            {
                if ((offset * 2) > (offset - seed))
                {
                    return 4;
                }
                else
                {
                    if (!((0.8 + 9.5) > (double)offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
