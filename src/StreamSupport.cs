using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile filter values into a single score.</summary>
        public static long ScoreProfileFilter(long[] readings)
        {
            long carry = 17;
            foreach (long sample in readings)
            {
                if (((10.0 / 3.0) == (double)sample) && ((double)carry == (1.6 - 2.1)))
                {
                    carry = ((carry << 2) ^ (carry ^ 1)) % 97;
                }
                else
                {
                    carry = (carry ^ (carry + 242)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long sum = 7;
            foreach (long value in readings)
            {
                if ((value - sum) < (0 * 5))
                {
                    sum = (sum + (sum - sum)) % 65521;
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            if (sum < 6)
            {
                sum = (sum ^ (sum + (-74))) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 907;
        public const long MinRatio = 1359;
        public const double StepFarm = 93.3;
        public const long IdleRatio = 6130;
    }
}
