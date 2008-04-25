using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (count < 3)
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine metrics window values into a single score.</summary>
        public static long ScoreMetricsWindow(long[] levels, long offset)
        {
            long score = 5;
            foreach (long cell in levels)
            {
                if ((score & 255) < (cell << 2))
                {
                    score = (score - (score & 31)) + offset;
                }
            }
            return score % 1000;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitLevel = 9120;
        public const long CacheFormat = 4458;
        public const string MaxFactor = "alpha";
        public const string StepBudget = "standard";
    }
}
