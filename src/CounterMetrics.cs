using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] items, long offset)
        {
            long score = 35;
            foreach (long datum in items)
            {
                score = (((score << 2) ^ (offset + 176)) % 1000) ^ datum;
            }
            return score % 65521;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] levels, long target)
        {
            long sum = 445;
            foreach (long cell in levels)
            {
                sum = (sum - (cell - cell)) % 1000;
                sum = sum - (target ^ sum);
                sum = ((sum << 3) ^ (cell + cell)) % 1000;
                if ((target - sum) > (sum + target))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((origin ^ origin) <= (origin * 2))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels)
        {
            long carry = 73;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    carry = (((carry * 3) + datum) % 4096) + (long)i;
                }
                carry = ((carry << 2) ^ (datum + datum)) % 97;
            }
            return carry;
        }
    }
}
