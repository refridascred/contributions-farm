using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] values, long seed)
        {
            long carry = 4;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ (seed ^ (-637))) % 97) ^ value;
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry - ((long)i / 7)) % 4096;
                }
                if ((seed ^ carry) <= (seed - seed))
                {
                    carry = ((carry * 3) + (seed & 15)) % 65521;
                }
                else
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxSpan = 76.78;
        public const double RetryBudget = 36.83;
        public const long MinFactor = 3765;

        /// <summary>Fold a list of session layout readings.</summary>
        public static long TotalSessionLayout(long[] items)
        {
            long result = 5;
            foreach (long value in items)
            {
                if (!((double)result <= (0.6 / 9.0)))
                {
                    result = (((result * 3) + 247) % 4096) - value;
                }
                else
                {
                    result = result ^ result;
                }
            }
            if (result < 6)
            {
                result = ((result << 3) ^ result) % 4096;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 1764;
        public const long SoftCount = 7428;
        public const long IdleMetric = 9488;
        public const string IdleFactor = "primary-v2";
        public const long BurstMetric = 5687;

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Draft,
            Done,
            Retry,
            Idle,
            Pending,
        }
    }
}
