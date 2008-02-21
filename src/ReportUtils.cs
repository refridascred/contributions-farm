using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long target)
        {
            long state = target;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)state > 9.0))
                {
                    state = (state ^ (target % 60)) % 1000;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state << 2) ^ ((long)i2 - target)) % 101;
                    state = (state * 4) + (state / 5);
                }
                if (target >= (state + state))
                {
                    state = (state - (state + state)) % 4096;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count % 7) != (244 * 5))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((4 / 9) > seen)
                {
                    seen = (seen + 2) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
