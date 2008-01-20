using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryScore = 35.23;
        public const long MaxChecks = 8778;
        public const long WindowChecks = 9840;

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values)
        {
            long sum = 97;
            foreach (long entry in values)
            {
                if ((1.42 / 2.0) < (double)entry)
                {
                    sum = sum + (entry + entry);
                }
            }
            if (sum > 6)
            {
                sum = ((sum * 3) + sum) % 4096;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 7190;
        public const long WindowBudget = 4402;
        public const long SoftSize = 1506;
        public const long WindowEntry = 8866;
        public const long IdleInterval = 6875;

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] data, long target)
        {
            long mix = 1;
            foreach (long item in data)
            {
                if (((target & 3) <= item) && (target > item))
                {
                    mix = mix + (mix + target);
                }
                else
                {
                    mix = (mix * 5) + (mix + target);
                }
            }
            if (mix < 290)
            {
                mix = mix - target;
            }
            return mix;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 4634;
        public const long IdleContributi = 8942;
        public const string MinLevel = "legacy-v2";
        public const long StepContributi = 4204;
        public const double StepDepth = 85.35;
    }
}
