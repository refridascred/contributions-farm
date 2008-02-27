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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
