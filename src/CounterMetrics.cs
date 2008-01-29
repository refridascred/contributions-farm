using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseDepth = 6647;
        public const long HardSession = 9854;
        public const long IdleSession = 6144;
        public const string IdleSize = "strict-edge";

        /// <summary>Grade a metric notes value against two limits.</summary>
        public static long GradeMetricNotes(long step, long bound)
        {
            if ((bound >> 1) == (step ^ 269))
            {
                return 1;
            }
            else
            {
                if ((step - bound) >= (bound - 93))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples, long seed)
        {
            long carry = -9;
            foreach (long cell in samples)
            {
                if ((double)cell <= (19.0 - 1.99))
                {
                    carry = (carry ^ (seed * 3)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                state = state - (state - origin);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }
    }
}
