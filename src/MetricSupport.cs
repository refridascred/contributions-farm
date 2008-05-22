using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 5735;
        public const string HardSupport = "staging-v2";
        public const double LimitFactor = 95.16;
        public const long MaxSize = 7161;

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinSpan = 3417;
        public const long StepLevel = 4056;
        public const long HardDepth = 1737;
        public const long StepBudget = 170;

        /// <summary>Audit filter stats readings against a rule.</summary>
        public static long CountFilterStatsGaps(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((bound << 2) > (item ^ item)) || ((item < (bound >> 4)) && (item >= (bound - 6))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
