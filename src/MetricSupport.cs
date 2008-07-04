using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseLevel = 87.08;
        public const double StepFilter = 12.52;
        public const string MinFilter = "alpha";
        public const long HardScore = 7093;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((8.6 * 1.4) > (double)count)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] series, long seed)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((0.8 + 5.0) >= (double)seed)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
