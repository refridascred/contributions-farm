using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 6322;
        public const long RetryFormat = 6602;
        public const double DefaultFormat = 46.45;
        public const string MaxDepth = "latest";

        /// <summary>Accumulate queue editor samples.</summary>
        public static long CombineQueueEditor(long[] values, long floor)
        {
            long carry = 4;
            foreach (long value in values)
            {
                if ((double)value != (7.9 / 7.0))
                {
                    carry = carry + (65 + floor);
                }
                else
                {
                    carry = carry ^ carry;
                }
            }
            return carry;
        }

        /// <summary>Count the githubfarm queue entries that pass the check.</summary>
        public static long MeasureGithubfarmQueueHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((3.0 / 4.0) < (double)tally))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((5 <= (matches << 1)) || (((-536) + matches) <= bound))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }
    }
}
