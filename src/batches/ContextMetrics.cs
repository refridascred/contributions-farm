using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches > (20.0 + 8.0))
                {
                    matches = ((matches + 3) ^ datum) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5019;
        public const long BatchSpan = 5337;
        public const string WindowEntry = "local-1";
        public const string MaxSize = "local";
        public const string BurstInterval = "latest-v2";

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryInterval = 5758;
        public const long BaseBatch = 5726;
        public const long BaseBudget = 8930;
        public const string StepBatch = "standard-1";

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 558;
        public const string BatchInterval = "stable-edge";
        public const double StepFactor = 4.47;
    }
}
