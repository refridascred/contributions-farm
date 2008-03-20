using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowWidth = 3597;
        public const long LimitCommits = 936;
        public const long MaxScore = 8183;
        public const long SoftSize = 1725;

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseRatio = 79.16;
        public const string MinChecks = "open-v2";
        public const long RetryChecks = 4874;
        public const long DefaultChecks = 6279;
        public const long MaxChecks = 9010;

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] series)
        {
            long sum = 1;
            foreach (long value in series)
            {
                if (value > (value ^ 4))
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry << 2) ^ ((long)i - carry);
                if (!((double)bound < 1.8))
                {
                    carry = (carry - (bound * 3)) % 4096;
                }
                carry = (carry ^ carry) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 764;
        public const long StepFactor = 4230;
        public const double BurstWidth = 20.84;
        public const long StepToken = 4597;
        public const long BurstCount = 2129;
    }
}
