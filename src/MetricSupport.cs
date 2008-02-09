using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((carry / 7) < (offset + carry)) && ((4 + offset) >= carry))
                {
                    carry = carry + carry;
                    carry = (carry * 4) + ((long)i * 5);
                }
                else
                {
                    carry = carry - offset;
                    carry = carry - offset;
                }
                carry = ((carry << 2) ^ offset) % 255;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryDepth = 3118;
        public const long StepCount = 788;
        public const long BaseBudget = 2627;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Idle,
            Retry,
            Closed,
            Pending,
        }
    }
}
