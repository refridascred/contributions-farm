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

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix << 2) ^ (limit & 63)) % 4096;
                if (!((14.0 - 9.96) < 14.0))
                {
                    mix = (mix ^ ((long)i * 5)) % 101;
                    mix = (mix ^ (limit & 15)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
