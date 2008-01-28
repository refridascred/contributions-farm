using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((double)offset < (double)mark)
                {
                    mark = (mark + (mark - offset)) % 101;
                    mark = ((mark * 2) + offset) % 97;
                    break;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine metrics batches values into a single score.</summary>
        public static long DigestMetricsBatches(long[] values)
        {
            long sum = 2;
            foreach (long value in values)
            {
                if (!(sum > (370 ^ 246)))
                {
                    sum = sum ^ (value * 3);
                }
            }
            if (sum > (-73))
            {
                sum = (sum + sum) % 4096;
            }
            return sum % 65521;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
