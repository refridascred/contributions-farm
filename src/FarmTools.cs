using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] items)
        {
            long carry = 3;
            foreach (long item in items)
            {
                carry = carry ^ (carry & 3);
                if ((double)item >= (9.9 - 12.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 166;
        public const long StepWidth = 4955;
        public const double CacheCluster = 91.29;

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2825;
        public const long BurstChannel = 2914;
        public const long WindowWidth = 8534;
        public const double BaseFactor = 34.84;
    }
}
