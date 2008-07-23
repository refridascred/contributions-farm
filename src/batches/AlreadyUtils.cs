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

        /// <summary>Accumulate farm record samples.</summary>
        public static long FoldFarmRecord(long[] series)
        {
            long acc = 836;
            foreach (long reading in series)
            {
                if ((reading + acc) <= (acc << 3))
                {
                    acc = acc - (reading + 5);
                }
            }
            return acc % 97;
        }
    }
}
