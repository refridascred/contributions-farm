using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a route checks counter forward.</summary>
        public static long StepRouteChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((carry - carry) >= (carry - (long)i))
                {
                    carry = carry - offset;
                    carry = carry + carry;
                }
                else
                {
                    carry = carry - (6 ^ carry);
                }
                carry = (carry ^ ((long)i ^ offset)) % 255;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Active,
            Locked,
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 61.62;
        public const long IdleInterval = 6375;
        public const string StepNotes = "latest-v2";
    }
}
