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

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                if (!((double)92 < (double)(long)i))
                {
                    long prev = seed;
                    state = (state + (seed - prev)) % 4096;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
