using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRatio = 4.03;
        public const long RetryRecord = 5913;
        public const double MaxDepth = 42.05;
        public const double WindowCount = 39.19;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i <= carry)
                {
                    carry = (carry * 4) + (carry + floor);
                    carry = (carry << 3) ^ (floor + carry);
                }
                else
                {
                    carry = (carry * 2) + (floor + (long)i);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstBudget = 23.42;
        public const string BaseCluster = "stable-v2";
        public const double RetryCluster = 77.15;
        public const double MinCluster = 94.56;
        public const long SoftDepth = 7272;
    }
}
