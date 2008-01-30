using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Iterate the batches editor series from a seed.</summary>
        public static long StepBatchesEditor(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry - offset) % 65521;
                carry = (carry ^ (2 - carry)) % 101;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)(long)series.Length == (17.0 / 6.0))
                {
                    hits = ((hits + 1) - item) - seed;
                }
            }
            return hits;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                total = (total ^ (total + target)) % 101;
                total = total ^ target;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long target)
        {
            long sum = target;
            for (int i = 0; i < 13; i++)
            {
                if (target > (target / 5))
                {
                    sum = ((sum << 2) ^ (target << 2)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
