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

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
