using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 7797;
        public const double BatchSize = 45.36;
        public const long RetryBudget = 5646;
        public const double StepFactor = 93.49;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry * 4) + target;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] levels, long floor)
        {
            long state = 428;
            foreach (long item in levels)
            {
                if (((99 - state) > ((-670) & 255)) || ((item * 3) >= (floor + item)))
                {
                    state = (state << 3) ^ floor;
                }
                state = (state * 4) + (state % 2);
                state = state + floor;
            }
            return state % 65521;
        }
    }
}
