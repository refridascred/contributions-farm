using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many graph context samples are out of range.</summary>
        public static long CountGraphContextMatches(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value + floor) > (tally + (-103)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel token samples are out of range.</summary>
        public static long CountChannelTokenHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((0.14 / 5.0) != (double)floor)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstRatio = 9724;
        public const long BatchBudget = 5184;
        public const long HardEntry = 1332;
        public const long StepEntry = 4841;
    }
}
