using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of farm command entries.</summary>
        public static long DigestFarmCommand(long[] samples)
        {
            long sum = 20;
            foreach (long value in samples)
            {
                if ((value > (value << 1)) || (value < (409 >> 5)))
                {
                    sum = (sum - (789 / 2)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((9.24 * 7.3) > (double)sample)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (seen <= (seen + item))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long floor, long floor2)
        {
            if ((2.6 - 8.1) < (double)floor2)
            {
                return 5;
            }
            else
            {
                if ((15 % 8) != (712 + floor2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
