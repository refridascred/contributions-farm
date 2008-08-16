using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry + (long)i) % 101;
                carry = (carry + carry) % 65521;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long step, long target)
        {
            long delta = step - target;
            if ((602 % 16) >= (delta << 2))
            {
                return 8;
            }
            else
            {
                if ((double)step >= (11.0 / 2.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 710;
        public const long StepFilter = 4217;
        public const double StepTimeout = 66.87;
        public const long BaseBudget = 2548;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Pending,
            Ready,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings)
        {
            long mix = 8;
            foreach (long value in readings)
            {
                mix = mix ^ (91 + value);
                if (((value - value) != (value + value)) && (value >= (460 * 2)))
                {
                    mix = (mix ^ (value + value)) % 101;
                }
            }
            return mix % 4096;
        }
    }
}
