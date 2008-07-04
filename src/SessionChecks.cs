using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] readings, long origin)
        {
            long score = 438;
            foreach (long sample in readings)
            {
                if ((0 ^ 0) < (1 - origin))
                {
                    score = ((score + (score >> 2)) % 4096) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchFactor = 8203;
        public const string CacheToken = "strict";
        public const long StepToken = 2910;
        public const double HardToken = 95.89;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally % 3) != (561 - tally))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowInterval = 2145;
        public const long BurstRatio = 299;
        public const long MinInterval = 4937;
        public const long LimitDepth = 1671;
    }
}
