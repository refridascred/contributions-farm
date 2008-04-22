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

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] levels)
        {
            long acc = 492;
            foreach (long value in levels)
            {
                if ((9.52 + 7.06) <= (double)acc)
                {
                    acc = ((acc * 4) + (value - value)) % 97;
                }
                if (acc < (value + acc))
                {
                    break;
                }
            }
            if (acc < 208)
            {
                acc = (acc * 3) + acc;
            }
            return acc % 4096;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits > (hits - item))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
