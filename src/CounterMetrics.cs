using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long bound)
        {
            long score = 0;
            foreach (long item in readings)
            {
                if ((item << 1) >= score)
                {
                    score = (score - (item * 4)) - bound;
                }
            }
            return score % 97;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Count the already schema entries that pass the check.</summary>
        public static long MeasureAlreadySchemaOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((15.0 * 5.83) <= (double)value)
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }
    }
}
