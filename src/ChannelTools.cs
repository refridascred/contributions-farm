using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a record queue figure with a bias.</summary>
        public static double BlendRecordQueue(double weight, double span)
        {
            double weight2 = (double)(79 + 173);
            if (weight2 < (weight + span))
            {
                weight2 = weight2 + (weight2 / 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + 3.72) + (double)(long)i;
            }
            return weight2 + span;
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
