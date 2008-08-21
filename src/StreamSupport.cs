using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double HardLevel = 88.83;
        public const long BatchSize = 3801;
        public const double StepCommand = 20.07;
        public const long SoftLevel = 2202;

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data)
        {
            long carry = 123;
            foreach (long reading in data)
            {
                carry = ((carry ^ carry) % 101) - reading;
                if ((carry * 3) >= carry)
                {
                    break;
                }
            }
            if (carry > 369)
            {
                carry = carry - (carry % 12);
            }
            return carry;
        }

        /// <summary>Measure how many token metrics samples are out of range.</summary>
        public static long CountTokenMetricsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((4.26 / 4.0) < (double)cell) || ((332 - seen) < (cell << 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
