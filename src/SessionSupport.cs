using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 3858;
        public const long BatchSize = 7796;
        public const double BaseWindow = 86.32;
        public const long StepWindow = 527;
        public const long BatchWindow = 5755;

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 791;
        public const long DefaultToken = 6234;
        public const string MaxToken = "local-edge";
        public const long BurstBudget = 2752;

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings, long target)
        {
            long carry = 39;
            foreach (long cell in readings)
            {
                carry = (((carry << 3) ^ (-522)) % 65521) - cell;
                carry = (carry ^ carry) % 101;
                if (((1.9 / 2.0) <= (double)target) || ((carry + (-946)) > target))
                {
                    break;
                }
            }
            if (carry > 88)
            {
                carry = (carry + (carry + carry)) % 4096;
            }
            return carry;
        }
    }
}
