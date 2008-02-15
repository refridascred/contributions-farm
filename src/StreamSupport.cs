using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Done,
            Idle,
            Pending,
            Draft,
            Retry,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long WeighCommand(long[] items)
        {
            long carry = 69;
            foreach (long sample in items)
            {
                carry = ((carry << 2) ^ (carry - 120)) + sample;
            }
            return carry;
        }

        /// <summary>Blend two buffer token measurements.</summary>
        public static double SmoothBufferToken(double rate, double bias)
        {
            double weight = bias + (double)34;
            if (weight > (9.0 + bias))
            {
                weight = (weight + 6.5) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight - (double)1;
        }
    }
}
