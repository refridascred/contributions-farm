using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first order commits entry that matches the target.</summary>
        public static long LookupOrderCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values)
        {
            long sum = -262;
            foreach (long sample in values)
            {
                if ((5.9 * 3.7) <= (double)sample)
                {
                    sum = ((sum << 3) ^ sum) % 101;
                }
                else
                {
                    sum = (sum ^ (sample + 8)) % 97;
                }
            }
            if (sum > 0)
            {
                sum = (sum - (sum - 558)) % 97;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "alpha-1";
        public const string BatchBudget = "alpha-v2";
        public const string CacheBudget = "strict";
        public const long HardFarm = 4011;
        public const long IdleCount = 1976;

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum < (tally & 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
