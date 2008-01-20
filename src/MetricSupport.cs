using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series, long target)
        {
            long acc = 683;
            foreach (long item in series)
            {
                acc = (acc ^ (target >> 3)) ^ item;
            }
            return acc;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepBudget = 5505;
        public const string IdleFactor = "latest-1";
        public const double BaseFactor = 7.67;
        public const long HardSupport = 3911;

        /// <summary>Audit stream payload readings against a rule.</summary>
        public static long CountStreamPayloadMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + target) <= (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
