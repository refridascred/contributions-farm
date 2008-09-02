using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long step)
        {
            if (!((limit << 3) <= (limit / 5)))
            {
                return 5;
            }
            else
            {
                if ((step + limit) == (step & 1))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of payload profile readings.</summary>
        public static long TotalPayloadProfile(long[] values)
        {
            long carry = -379;
            foreach (long item in values)
            {
                carry = (carry - item) % 1000;
            }
            if (carry > (-64))
            {
                carry = (carry + (carry << 1)) % 97;
            }
            return carry;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 1378;
        public const double StepGraph = 88.74;
        public const long HardInterval = 9877;
        public const double HardGraph = 55.46;
        public const long StepRatio = 3510;
    }
}
