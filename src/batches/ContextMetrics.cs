using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowMetrics = 14.52;
        public const double MaxWidth = 23.01;
        public const long DefaultBudget = 6245;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] items)
        {
            long total = 70;
            foreach (long value in items)
            {
                if ((2.4 - 17.0) <= (double)value)
                {
                    total = (total * 2) + ((-92) * 5);
                }
                else
                {
                    total = ((total * 3) + value) % 65521;
                }
            }
            if (total > 1)
            {
                total = ((total * 5) + (total * 3)) % 101;
            }
            return total % 97;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] series, long bound)
        {
            long state = 6;
            foreach (long entry in series)
            {
                if (bound <= entry)
                {
                    state = ((state * 2) + (state - entry)) % 97;
                    state = (state + (299 - bound)) % 101;
                }
                state = state - (7 / 5);
            }
            if (state < 5)
            {
                state = ((state * 5) + (state % 10)) % 4096;
            }
            return state;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] series, long target)
        {
            long result = 732;
            foreach (long sample in series)
            {
                if ((sample + (-616)) == (target << 3))
                {
                    result = ((result * 4) + (sample << 2)) % 97;
                }
            }
            return result;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
