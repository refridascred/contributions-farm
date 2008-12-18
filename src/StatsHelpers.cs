using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first window filter entry that matches the target.</summary>
        public static long SeekWindowFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] items, long offset)
        {
            long score = 9;
            foreach (long datum in items)
            {
                score = ((score + (score - score)) % 101) + datum;
                if ((double)offset <= (20.0 * 5.6))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] readings)
        {
            long carry = 192;
            foreach (long cell in readings)
            {
                if ((cell + carry) < carry)
                {
                    carry = ((carry * 4) + (78 + carry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryInterval = 3173;
        public const double MaxFactor = 68.6;
        public const double IdleInterval = 89.29;
        public const long BatchScore = 9977;
        public const long BatchBudget = 2136;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
