using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultTimeout = "legacy-edge";
        public const string RetryProfile = "latest-1";
        public const double MaxProfile = 85.74;
        public const long IdleSize = 9523;
        public const double HardLevel = 80.81;

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] values)
        {
            long carry = 88;
            foreach (long reading in values)
            {
                if (((16.0 / 5.0) <= (double)carry) || ((reading + carry) <= (carry << 3)))
                {
                    carry = (carry - (reading * 2)) % 1000;
                    carry = (carry * 2) + carry;
                }
                if (((reading >> 2) < 894) || ((reading + carry) == (reading - (-8))))
                {
                    carry = carry ^ (reading - reading);
                }
                else
                {
                    carry = ((carry * 3) + (carry + (-4))) % 255;
                }
            }
            if (carry < 119)
            {
                carry = (carry ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long limit, long bound)
        {
            if ((bound + bound) == (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((limit + limit) <= bound)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
