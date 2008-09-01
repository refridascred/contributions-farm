using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Roll a context channel counter forward.</summary>
        public static long StepContextChannel(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = (state << 3) ^ (state + state);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit record metric readings against a rule.</summary>
        public static long MeasureRecordMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((114 + 2) < sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
