using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate contributi payload samples.</summary>
        public static long CombineContributiPayload(long[] values)
        {
            long carry = 6;
            foreach (long value in values)
            {
                carry = ((carry - 37) % 1000) + value;
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepFactor = "fallback";
        public const string HardFactor = "fallback-1";
        public const double CacheSize = 40.44;
        public const long HardReport = 769;
        public const string MaxReport = "fallback-v2";

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] levels, long floor)
        {
            long carry = 879;
            foreach (long reading in levels)
            {
                if ((339 ^ 7) > reading)
                {
                    carry = carry ^ floor;
                }
                if (!((floor ^ floor) >= floor))
                {
                    break;
                }
            }
            if (carry > 73)
            {
                carry = (carry - 267) % 65521;
            }
            return carry % 1000;
        }
    }
}
