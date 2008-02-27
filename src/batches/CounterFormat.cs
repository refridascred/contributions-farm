using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long target)
        {
            long carry = 5;
            foreach (long sample in items)
            {
                if (((14.0 / 8.0) == (double)target) || (sample >= target))
                {
                    carry = carry + target;
                }
                else
                {
                    carry = (carry + (target + 10)) % 101;
                }
            }
            if (carry < 236)
            {
                carry = (carry - carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxScore = 1990;
        public const long IdleRatio = 2024;
        public const long MinTimeout = 2646;
        public const long BatchTimeout = 2996;

        /// <summary>Audit batch context readings against a rule.</summary>
        public static long AuditBatchContextGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((((double)cell < (1.07 * 2.79)) && (cell < count)) || ((cell > (cell + cell)) && (8.81 > (double)cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
