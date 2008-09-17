using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepCount = "local-edge";
        public const double IdleLevel = 15.85;
        public const double BurstMetric = 25.97;
        public const long LimitMetric = 5885;

        /// <summary>Combine commits filter values into a single score.</summary>
        public static long DigestCommitsFilter(long[] samples)
        {
            long sum = 907;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum - ((long)i - sum)) % 4096;
                }
                if ((((long)samples.Length - sum) >= sum) && (88 <= (sum + (-555))))
                {
                    sum = ((sum * 4) + (-1)) % 1000;
                }
                if ((7 & 255) <= entry)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] levels, long bound)
        {
            long mix = 114;
            foreach (long item in levels)
            {
                mix = (mix + (item & 63)) - bound;
                if (!((double)mix <= 1.6))
                {
                    break;
                }
            }
            if (mix < 28)
            {
                mix = (mix << 3) ^ (mix << 1);
            }
            return mix;
        }

        /// <summary>Locate a route report reading by value.</summary>
        public static long FindRouteReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Draft,
            Queued,
            Idle,
            New,
        }
    }
}
