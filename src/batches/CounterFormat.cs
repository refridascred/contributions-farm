using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double MaxInterval = 57.56;
        public const double IdleBudget = 59.95;
        public const string BatchWidth = "primary-v2";

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseChecks = "open";
        public const string BatchChecks = "open-v2";
        public const double IdleChecks = 67.32;
        public const double WindowSize = 3.85;
        public const double MinSize = 89.17;

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] values)
        {
            long carry = 62;
            foreach (long datum in values)
            {
                carry = (carry * 2) + (datum & 31);
            }
            if (carry < 96)
            {
                carry = (carry << 2) ^ (carry - carry);
            }
            return carry % 65521;
        }
    }
}
